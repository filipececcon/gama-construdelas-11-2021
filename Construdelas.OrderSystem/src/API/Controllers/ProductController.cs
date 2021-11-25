using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construdelas.OrderSystem.Application.Commands;
using Construdelas.OrderSystem.Application.Requests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Construdelas.OrderSystem.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ProductRepository.Products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {            
            return Ok();
        }


        [HttpPost]
        public IActionResult Add([FromBody] AddProductRequest request)
        {
            var handler = new AddProductCommandHandler();

            var response = handler.Handle(request);

            return Created("", response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateProductRequest request)
        {
            return Ok();
        }
    }   
}
