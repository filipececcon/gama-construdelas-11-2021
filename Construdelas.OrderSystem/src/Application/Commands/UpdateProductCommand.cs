using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class UpdateProductCommand : Handler<UpdateProductRequest, UpdateProductResponse>
    {
        public override UpdateProductResponse Handle(UpdateProductRequest request)
        {
            var product = ProductRepository.Products.Single(p => p.Id == request.Id);

            product.Name = request.Name;
            product.UnitValue = request.UnitValue;
            product.UpdatedAt = DateTime.Now;

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
