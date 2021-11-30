using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Queries.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;
using Construdelas.OrderSystem.Domain.Shared.Predicates;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetAllOrderQuery : IGetAllOrderQuery
    {
        private readonly IRepository<Order> repository;

        public GetAllOrderQuery(IRepository<Order> repository)
        {
            this.repository = repository;
        }

        public IQueryable<GetAllOrderResponse> Handle(GetAllOrderRequest request)
        {
            var predicate = PredicateBuilder.New<Order>();


            return repository
                .Get(predicate)
                .Select(o => new GetAllOrderResponse
                {
                    Id = o.Id,
                    CreatedAt = o.CreatedAt,
                    UpdatedAt = o.UpdatedAt,
                    Total = o.GetTotal(),
                    ItemsCount = o.Items.Count
                });
            ;
        }
    }
}
