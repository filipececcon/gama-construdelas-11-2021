using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class UpdateProductCommand : IHandler<UpdateProductRequest, UpdateProductResponse>
    {
        private readonly ProductRepository _repository;

        public UpdateProductCommand(ProductRepository repository)
        {
            _repository = repository;
        }

        public UpdateProductResponse Handle(UpdateProductRequest request)
        {
            var product = _repository.GetById(request.Id);

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
