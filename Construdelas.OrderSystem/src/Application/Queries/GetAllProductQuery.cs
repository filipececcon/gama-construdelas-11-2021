using System;
using System.Collections.Generic;
using System.Linq;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetAllProductQuery : IGetAllProductQuery
    {
        private readonly IProductRepository _repository;

        public GetAllProductQuery(IProductRepository repository)
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
                    UpdatedAt = p.UpdatedAt,
                    IsActive = p.IsActive
                });
        }
    }
}
