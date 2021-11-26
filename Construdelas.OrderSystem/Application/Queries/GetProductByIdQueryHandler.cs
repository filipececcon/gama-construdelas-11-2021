using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetProductByIdQueryHandler : Handler<GetProductByIdRequest, GetProductByIdResponse>
    {
        public override GetProductByIdResponse Handle(GetProductByIdRequest request)
        {
            var product = ProductRepository.Products.Single(x => x.Id == request.Id);

            return new GetProductByIdResponse()
            {
                Id = product.Id,
                Name = product.Name,
                CreatedAt = product.CreatedAt,
                UnitValue = product.UnitValue,
                UpdatedAt = product.UpdatedAt,
                IsActive = product.IsActive
            };
        }
    }
}
