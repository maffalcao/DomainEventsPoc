using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dto;
using Domain.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {        
        private readonly ICreateCustomerHandler _handler;
        public CustomersController(ICreateCustomerHandler handler)
        {        
            _handler = handler;    
        }

        [HttpPost]
        public IActionResult Post([FromBody] CustomerDto customerDto)
        {           

           return Ok(_handler.Add(customerDto.Name, customerDto.Email));
        }
    }
}
