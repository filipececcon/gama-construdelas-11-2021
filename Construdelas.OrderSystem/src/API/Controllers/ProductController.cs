using System;
using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Queries.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Construdelas.OrderSystem.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IGetAllProductQuery query, [FromQuery] GetAllProductRequest request)
        {
            return Ok(query.Handle(request));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromServices] IGetProductByIdQuery query, [FromRoute] Guid id)
        {
            var request = new GetProductByIdRequest() { Id = id };

            return Ok(query.Handle(request));
        }


        [HttpPost]
        public IActionResult Add([FromServices] IAddProductCommand command, [FromBody] AddProductRequest request)
        {            
            return Created("", command.Handle(request));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromServices] IRemoveProductByIdCommand command, [FromRoute] Guid id)
        {
            var request = new RemoveProductByIdRequest() { Id = id };

            return Ok(command.Handle(request));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromServices] IUpdateProductCommand command,[FromRoute] Guid id, [FromBody] UpdateProductRequest request)
        {
            request.Id = id;

            try
            {
                return Ok(command.Handle(request));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult ChangeStatus([FromServices] IChangeStatusCommand<Product> command, [FromRoute] Guid id, [FromBody] ChangeStatusRequest request)
        {
            request.Id = id;

            return Ok(command.Handle(request));
        }
    }   
}
