using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class UpdateProductCommand : IUpdateProductCommand
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommand(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public UpdateProductResponse Handle(UpdateProductRequest request)
        {
            var product = _repository.GetById(request.Id);

            if (!product.IsActive) throw new ArgumentException("o produto está inativo");

            product.Name = request.Name;
            product.UnitValue = request.UnitValue;

            _repository.Update(product);
            
            return new UpdateProductResponse()
            {
                Id = product.Id,
                Name = product.Name,
                UnitValue = product.UnitValue,
                UpdatedAt = product.UpdatedAt
            };

        }
    }
}
