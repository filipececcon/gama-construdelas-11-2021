using System;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Contexts;

namespace Construdelas.OrderSystem.Infra.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(OrderSystemContext context) : base(context) { }
    }
}
