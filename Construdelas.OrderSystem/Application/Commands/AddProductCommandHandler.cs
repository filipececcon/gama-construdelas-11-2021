using System;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddProductCommandHandler
    {
        public AddProductResponse Handle(AddProductRequest request)
        {
            var product = new Product(request.Name, request.UnitValue);

            ProductRepository.Products.Add(product);

            var response = new AddProductResponse() { Id = product.Id, Name = product.Name, CreatedAt = product.CreatedAt };

            return response;
        }
    }
}
