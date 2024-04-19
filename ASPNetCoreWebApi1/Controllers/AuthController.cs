using ASPNetCoreWebApi1.Models;
using ASPNetCoreWebApi1.Services;
using ASPNetCoreWebApi1.Services.Impl;
using ASPNetCoreWebApi1.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Services.WebApi.Jwt;

namespace ASPNetCoreWebApi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;
        private readonly AuthenticationService authenticationService;

        public AuthController(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
            authenticationService = new AuthenticationService();
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] UserCredentials userCredentials)
        {
            try
            {
                string token = authenticationService.Authenticate(userCredentials);
                return Ok(token);
            }
            catch (InvalidCredentialsException)
            {
                return Unauthorized();
            }
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] UserCredentials userCredentials)
        {
            try
            {
                string token = authenticationService.Authenticate(userCredentials);
                return Ok(token);
            }
            catch (InvalidCredentialsException)
            {
                return Unauthorized();
            }
        }
    }
}
