using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construdelas.OrderSystem.Application.Commands;
using Construdelas.OrderSystem.Application.Queries;
using Construdelas.OrderSystem.Application.Requests;
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
        private readonly ProductRepository _repository;

        public ProductController(OrderSystemContext context)
        {
            _repository = new ProductRepository(context);
        }


        [HttpGet]
        public IActionResult Get()
        {
            var handler = new GetAllProductQuery(_repository);

            var response = handler.Handle(new GetAllProductRequest());

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var request = new GetProductByIdRequest() { Id = id };

            var handler = new GetProductByIdQuery(_repository);

            var response = handler.Handle(request);

            return Ok(response);
        }


        [HttpPost]
        public IActionResult Add([FromBody] AddProductRequest request)
        {
            var command = new AddProductCommand(_repository);

            var response = command.Handle(request);

            return Created("", response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            var request = new RemoveProductByIdRequest() { Id = id };

            var handler = new RemoveProductByIdCommand(_repository);
            
            var response = handler.Handle(request);

            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateProductRequest request)
        {
            request.Id = id;

            var handler = new UpdateProductCommand(_repository);

            var response = handler.Handle(request);

            return Ok(response);
        }
    }   
}
