using System;
using System.Collections.Generic;
using Construdelas.OrderSystem.Application.Commands.interfaces;
using Construdelas.OrderSystem.Application.Commands.Interfaces;
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

        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices] IRemoveOrderByIdCommand command, [FromRoute] RemoveOrderByIdRequest request)
        {
            return Ok(command.Handle(request));
        }


        [HttpPost]
        [Route("{id}/item")]
        public IActionResult AddItem([FromServices] IAddOrderItemCommand command, [FromRoute] Guid id, [FromBody] AddOrderItemRequest request)
        {
            request.OrderId = id;

            return Created("", command.Handle(request));
        }

        [HttpDelete]
        [Route("{id}/item/{itemId}")]
        public IActionResult RemoveItem([FromServices] IRemoveOrderItemByIdCommand command, [FromRoute] Guid id, [FromRoute] Guid itemId)
        {
            var request = new RemoveOrderItemRequest(itemId, id);

            return Ok(command.Handle(request));
        }


        [HttpGet]
        [Route("{orderid}/item/{itemId}")]
        public IActionResult GetOrdeItemById([FromServices] IGetByIdOrderItemQuery query, [FromRoute] GetByIdOrderItemRequest request)
        {
            var response = query.Handle(request);

            return response == null? NotFound() : Ok(response);
        }
    }
}

/*
 
 Pedido - existe sem independentemente de qualquer outro objeto
 item de pedido - nao existe sem um pedido


Entidades que são indepedentes de outras para existirem são consideradas Raiz de Agregação

Entidades que são depedentes de outras para existirem são consideradas Agregados
 

/order/{id}/item/

 */
