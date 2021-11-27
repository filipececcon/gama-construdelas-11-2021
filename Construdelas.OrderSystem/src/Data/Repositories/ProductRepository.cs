using System;
using System.Collections.Generic;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Infra.Data.Contexts;

namespace Construdelas.OrderSystem.Infra.Data.Repositories
{
    public class ProductRepository
    {
        private OrderSystemContext _context;

        public ProductRepository(OrderSystemContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);

            _context.SaveChanges();
        }

        public Product GetById(Guid id)
        {
            return _context.Products.Find(id);
        }
    }
}
