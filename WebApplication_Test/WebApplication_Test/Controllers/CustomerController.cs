using BussinesLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dto;
using System.IO.Pipes;

namespace WebApplication_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService= customerService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get() 
        {
            return Ok(_customerService.Get());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Create([FromBody] CustomerDto dto)
        {
            return Ok(_customerService.Create(dto));
        }
    }
}
