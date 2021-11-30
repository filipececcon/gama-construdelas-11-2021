using System;
using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class UpdateProductCommand : CommandBase<Product>, IUpdateProductCommand
    {
        public UpdateProductCommand(IRepository<Product> repository) : base(repository)
        {
        }

        public UpdateProductResponse Handle(UpdateProductRequest request)
        {
            var product = repository.GetById(request.Id);

            if (!product.IsActive) throw new ArgumentException("o produto está inativo");

            product.Name = request.Name;
            product.UnitValue = request.UnitValue;

            repository.Update(product);
            
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
