using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using System.Linq;
using DevFramework.Core.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using DevFramework.Service.Dto;
using Microsoft.Extensions.Options;
using DevFramework.Domain.Config;
using DevFramework.Domain.Model;
using System.Net;
using System.Collections.Generic;
using DevFramework.Data.Repository;
using Microsoft.AspNetCore.Http;
using DevFramework.Core.Infrastructure.Utils;

namespace DevFramework.Service
{

    public class DistanceService : BaseService, IDistanceService
    {
        readonly IUnitOfWork _unitofWork;
        readonly IDistanceRepository _distanceRepo;
        readonly IRequestRepository _RequestRepo;
        readonly ILogger<DistanceService> _logger;
        readonly IMapper _mapper;
        readonly HttpContext _context;

        public DistanceService(IUnitOfWork unitOfWork, IDistanceRepository distanceRepository, IHttpContextAccessor accessor, IRequestRepository requestRepository, ILogger<DistanceService> logger, IMapper mapper, IOptionsSnapshot<AppSetting> setting) : base(setting)
        {
            _unitofWork = unitOfWork ?? throw new ArgumentNullException(nameof(DistanceService));
            _distanceRepo = distanceRepository;
            _context = accessor.HttpContext;
            _RequestRepo = requestRepository;
            _logger = logger ?? throw new ArgumentNullException(nameof(DistanceService));
            _mapper = mapper;
        }

        public async Task<double> GetDistance(double fromLat, double fromLong, double toLat, double tolong)
        {

            if (!int.TryParse(_context.User.Claims.FirstOrDefault(cl => cl.Type == "id")?.Value, out var userId))
            {
                RaiseError("unauthorized", HttpStatusCode.Unauthorized);
            }

            var distance = await _distanceRepo.GetQueryableItems(predicate: en => en.FromLat == fromLat && en.FromLong == fromLong && en.ToLat == toLat && en.ToLong == tolong).SingleOrDefaultAsync();
            var request = new Request()
            {
                UserId = userId
            };

            if (distance == null)
            {
                request.Distance = new Distance()
                {
                    FromLat = fromLat,
                    FromLong = fromLong,
                    ToLat = toLat,
                    ToLong = tolong,
                    Value = GeoUtil.GetDistance(fromLat, fromLong, toLat, tolong)
                };
            }

            if (distance != null)
            {
                request.DistanceId = distance.Id;
            }

            await _RequestRepo.InsertAsync(request);
            await _unitofWork.SaveChangesAsync();

            return distance != null ? distance.Value : request.Distance.Value;

        }

        public Task<List<RequestDto>> GetUserRequests()
        {
            if (!int.TryParse(_context.User.Claims.FirstOrDefault(cl => cl.Type == "id")?.Value, out var userId))
            {
                RaiseError("unauthorize", HttpStatusCode.Unauthorized);
            }
            
            return _RequestRepo.GetQueryableItems(predicate: en => en.UserId == userId).Select(en => new RequestDto
            {
                UserId = en.UserId,
                CreateOn = en.CreateOn,
                Distance = new DistanceDto()
                {
                    FromLat = en.Distance.FromLat,
                    FromLong = en.Distance.FromLong,
                    ToLat = en.Distance.ToLat,
                    ToLong = en.Distance.ToLong,
                    Value = en.Distance.Value,
                }
            }).ToListAsync();
        }



    }

}