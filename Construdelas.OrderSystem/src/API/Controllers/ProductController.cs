using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construdelas.OrderSystem.Application.Commands;
using Construdelas.OrderSystem.Application.Queries;
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
            var request = new GetAllProductRequest();

            var handler = new GetAllProductQuery();

            var response = handler.Handle(request);

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var request = new GetProductByIdRequest() { Id = id };

            var handler = new GetProductByIdQuery();

            var response = handler.Handle(request);

            return Ok(response);
        }


        [HttpPost]
        public IActionResult Add([FromBody] AddProductRequest request)
        {
            var command = new AddProductCommand();

            var response = command.Handle(request);

            return Created("", response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            var request = new RemoveProductByIdRequest() { Id = id};

            var handler = new RemoveProductByIdCommand();

            var response = handler.Handle(request);

            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateProductRequest request)
        {
            request.Id = id;

            var handler = new UpdateProductCommand();

            var response = handler.Handle(request);

            return Ok(response);
        }
    }   
}
