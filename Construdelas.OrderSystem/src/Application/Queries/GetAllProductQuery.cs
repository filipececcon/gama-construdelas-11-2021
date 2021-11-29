using System;
using System.Collections.Generic;
using System.Linq;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;
using Construdelas.OrderSystem.Domain.Shared.Predicates;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetAllProductQuery : IGetAllProductQuery
    {
        private readonly IRepository<Product> _repository;

        public GetAllProductQuery(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public IQueryable<GetAllProductResponse> Handle(GetAllProductRequest request)
        {
            var predicate = PredicateBuilder.New<Product>();

            if (request.IsActive != null) predicate = predicate.And(p => p.IsActive == request.IsActive);

            if (request.GteUnitvalue != null) predicate = predicate.And(p => p.UnitValue >= request.GteUnitvalue);

            if (request.LteUnitvalue != null) predicate = predicate.And(p => p.UnitValue <= request.LteUnitvalue);

            return _repository
               .Get(predicate)
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
