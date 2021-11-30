using System.Collections.Generic;
using Construdelas.OrderSystem.Application.Commands.interfaces;
using Construdelas.OrderSystem.Application.Queries.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Construdelas.OrderSystem.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get([FromServices] IGetAllOrderQuery query, [FromQuery] GetAllOrderRequest request)
        {
            return Ok(query.Handle(request));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromServices] IAddOrderCommand command,  [FromBody] AddOrderRequest request)
        {
            return Created("", command.Handle(request));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
