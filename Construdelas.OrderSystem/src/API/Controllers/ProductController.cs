using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var nome = ProductRepository.Products.SingleOrDefault(x => x.Key == id).Value;

            if (nome == null) return NotFound();

            var response = new { nome, id };

            return Ok(response);
        }


        [HttpPost]
        public IActionResult Add([FromBody] AddProductRequest request)
        {
            var id = Guid.NewGuid();

            ProductRepository.Products.Add(id, request.Nome);

            var response = new { id, request.Nome};

            return Created("", response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            ProductRepository.Products.Remove(id);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateProductRequest request)
        {
            request.Id = id;

            ProductRepository.Products[id] = request.Nome;

            var response = new { id, request.Nome };

            return Ok(response);
        }
    }

    public class AddProductRequest
    {
        public string Nome { get; set; }
    }

    public class UpdateProductRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
