using ASPNetCoreWebApi1.ApplicationLayer.Commands;
using ASPNetCoreWebApi1.ApplicationLayer.Queries.EmployeeQuery;
using ASPNetCoreWebApi1.DomainLayer.Entity;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNetCoreWebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        private readonly ILogger<WeatherForecastController> _logger;

        public EmployeeController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            this.mediator = mediator;
            _logger = logger;
        }

        /// <summary>
        /// GET: api/<EmployeeController>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Get Employee");
            return Ok(await mediator.Send(new GetEmployeeListQuery()));
        }

        /// <summary>
        /// GET: api/<EmployeeController>/{id}
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await mediator.Send(new GetEmployeeByIdQuery() { Id = id }));

        /// <summary>
        /// POST: api/<EmployeeController>
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employee employeeDto) => Ok(await mediator.Send(new CreateEmployeeCommand() { employee = employeeDto }));

        /// <summary>
        /// POST: api/<EmployeeController>
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Employee employeeDto) => Ok(await mediator.Send(new UpdateEmployeeCommand() { employee = employeeDto }));

        /// <summary>
        /// POST: api/<EmployeeController>
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => Ok(await mediator.Send(new DeleteEmployeeCommand() { Id = id }));
    }
}
