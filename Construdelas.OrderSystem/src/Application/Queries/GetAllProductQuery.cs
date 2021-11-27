using System;
using System.Collections.Generic;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetAllProductQuery : IHandler<GetAllProductRequest, IQueryable<GetAllProductResponse>>
    {
        private readonly ProductRepository _repository;

        public GetAllProductQuery(ProductRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<GetAllProductResponse> Handle(GetAllProductRequest request)
        {
            return _repository
                .Get(p => p.IsActive)
                .Select(p => new GetAllProductResponse()
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
