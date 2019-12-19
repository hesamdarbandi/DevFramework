using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using System.Linq;
using DevFramework.Core.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using DevFramework.Service.Dto;
using DevFramework.Core.Infrastructure.Model;
using Microsoft.Extensions.Options;
using DevFramework.Domain.Config;
using DevFramework.Core.Infrastructure.Auth;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using DevFramework.Domain.Model;
using System.Net;

namespace DevFramework.Service
{

    public class AuthService : BaseService, IAuthService
    {
        readonly UserManager<User> _userManager;
        readonly IUnitOfWork _unitofWork;
        readonly IJwtFactory _jwtFactory;
        readonly JwtIssuerOptions _jwtOptions;
        readonly ILogger<AuthService> _logger;
        readonly IMapper _mapper;

        public AuthService(IUnitOfWork unitOfWork, UserManager<User> userManager, ILogger<AuthService> logger, IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions, IMapper mapper, IOptionsSnapshot<AppSetting> setting) : base(setting)
        {
            _unitofWork = unitOfWork ?? throw new ArgumentNullException(nameof(AuthService));
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;
            _userManager = userManager;
            _logger = logger ?? throw new ArgumentNullException(nameof(AuthService));
            _mapper = mapper;
        }

        public async Task<string> Login(UserDto model)
        {
            if (string.IsNullOrEmpty(model.Email))
            {
                RaiseError("please enter email", HttpStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                RaiseError("please enter password", HttpStatusCode.BadRequest);
            }

            var user = await _userManager.FindByEmailAsync(model.Email.Trim());
            if (user == null)
            {
                user = new User() { Email = model.Email.Trim(), UserName = model.Email.Trim() };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    RaiseError("please try later");
                }
            }

            if (user != null)
            {
                var isCorrect = await _userManager.CheckPasswordAsync(user, model.Password);
                if (!isCorrect)
                {
                    RaiseError("password is incorect", HttpStatusCode.BadRequest);
                }
            }

            var identity = await GetClaimsIdentity(user.Email, user.Id.ToString());
            return await Tokens.GenerateJwt(identity, _jwtFactory, $"{user.Email}", $"{user.Email}", _jwtOptions, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }
        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string id)
        {
            return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, id));
        }
    }

}