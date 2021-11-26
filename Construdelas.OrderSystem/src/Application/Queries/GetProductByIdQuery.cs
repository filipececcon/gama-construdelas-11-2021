using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetProductByIdQuery : IHandler<GetProductByIdRequest, GetProductByIdResponse>
    {
        public GetProductByIdResponse Handle(GetProductByIdRequest request)
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
