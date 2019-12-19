using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevFramework.Service;
using DevFramework.Service.Dto;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace DevFramework.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class DistanceController : Controller
    {
        readonly IDistanceService _distanceService;
        public DistanceController(IDistanceService distanceService) => _distanceService = distanceService;

        [HttpGet]
        [ProducesResponseType(typeof(double), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(double? fromLat, double? fromLong, double? toLat, double? toLong)
        {
            return new ObjectResult(await _distanceService.GetDistance(fromLat.Value, fromLong.Value, toLat.Value, toLong.Value));
        }

        // [HttpGet]
        // [ProducesResponseType(typeof(List<RequestDto>), (int)HttpStatusCode.OK)]
        // public async Task<IActionResult> GetList()
        // {
        //     return new ObjectResult(await _distanceService.GetUserRequests());
        // }

    }
}
