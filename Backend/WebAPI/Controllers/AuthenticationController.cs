using Business.Abstract.Authentication;
using Entities.DTOs.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequestDto request)
        {
            var authResult = _authenticationService.Register(request);
            return Ok(request);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDto request)
        {
            var authResult= _authenticationService.Login(request);
            return Ok(request);
        }
    }
}
