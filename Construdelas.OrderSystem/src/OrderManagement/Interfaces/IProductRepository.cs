using System;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Domain.OrderManagement.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}
