using System;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Handlers;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddProductCommand : IHandler<AddProductRequest, AddProductResponse>
    {
        private ProductRepository _repository;

        public AddProductCommand(ProductRepository repository)
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
