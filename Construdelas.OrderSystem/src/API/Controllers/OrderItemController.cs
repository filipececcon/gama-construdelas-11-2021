using System;
using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Queries.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Construdelas.OrderSystem.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById([FromServices] IGetByIdOrderItemQuery query, Guid id)
        {
            var response = query.Handle(new GetByIdOrderItemRequest(id));

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromServices] IAddOrderItemCommand command, [FromBody] AddOrderItemRequest request)
        {
            return Created("",command.Handle(request));
        }

        
        [HttpPut("{id}")]
        public IActionResult Put([FromServices] IUpdateOrderItemCommand command, [FromRoute] Guid id, [FromBody] UpdateOrderItemRequest request)
        {
            request.Id = id;

            return Ok(command.Handle(request));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices] IRemoveOrderItemByIdCommand command, [FromRoute] Guid id)
        {
            return Ok(command.Handle(new RemoveOrderItemRequest(id)));
        }
    }
}
