using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using DevFramework.Service;
using DevFramework.Service.Dto;

namespace DevFramework.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        readonly IAuthService _authService;
        public AuthController(IAuthService authService) => _authService = authService;

        [HttpPost]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetList([FromBody] UserDto user)
        {
            return new ObjectResult(await _authService.Login(user));
        }

    }
}
