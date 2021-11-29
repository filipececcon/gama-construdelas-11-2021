using System;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddProductCommand : IAddProductCommand
    {
        private readonly IRepository<Product> _repository;

        public AddProductCommand(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public AddProductResponse Handle(AddProductRequest request)
        {
            var product = new Product(request.Name, request.UnitValue);

            _repository.Add(product);

            return new AddProductResponse()
            {
                Id = product.Id,
                Name = product.Name,
                CreatedAt = product.CreatedAt
            };
        }
    }
}
