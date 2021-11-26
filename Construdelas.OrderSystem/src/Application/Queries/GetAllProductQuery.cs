using System;
using System.Collections.Generic;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetAllProductQuery : Handler<GetAllProductRequest, IEnumerable<GetAllProductResponse>>
    {
        public override IEnumerable<GetAllProductResponse> Handle(GetAllProductRequest request)
        {
            return ProductRepository.Products.Select(p => new GetAllProductResponse()
            {
                Id = p.Id,
                Name = p.Name,
                CreatedAt = p.CreatedAt,
                UnitValue = p.UnitValue,
                UpdatedAt = p.UpdatedAt
            });
        }
    }
}
