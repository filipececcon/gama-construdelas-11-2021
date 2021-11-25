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
        public Dictionary<Guid, string> Get()
        {
            return ProductRepository.Products;
        }

        [HttpGet]
        [Route("{id}")]
        public string GetById([FromRoute] Guid id)
        {
            return ProductRepository.Products[id];
        }


        [HttpPost]
        public void Add([FromBody] AddProductRequest request)
        {
            ProductRepository.Products.Add(Guid.NewGuid(), request.Nome);
        }


        
    }

    public class AddProductRequest
    {
        public string Nome { get; set; }
    }
}
