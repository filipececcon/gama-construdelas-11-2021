using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construdelas.OrderSystem.Application.Commands;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Queries;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Contexts;
using Construdelas.OrderSystem.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Construdelas.OrderSystem.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IGetAllProductQuery query)
        {
            return Ok(query.Handle(new GetAllProductRequest()));
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
        public IActionResult ChangeStatus([FromServices] IProductChangeStatusCommand command, [FromRoute] Guid id, [FromBody] ChangeStatusRequest request)
        {
            request.Id = id;

            return Ok(command.Handle(request));
        }
    }   
}
