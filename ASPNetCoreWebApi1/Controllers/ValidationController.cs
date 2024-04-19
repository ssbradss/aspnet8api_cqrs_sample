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
    public class ValidationController : ControllerBase
    {
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Validate()
        {
            return Ok();
        }
    }
}
