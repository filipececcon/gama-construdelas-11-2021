using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Update(Product product)
        {
            product.UpdatedAt = DateTime.Now;

            _context.Products.Update(product);

            _context.SaveChanges();
        }

        public IQueryable<Product> Get(Expression<Func<Product,bool>> predicate = null)
        {
            return predicate == null
                ? _context.Products.AsQueryable()
                : _context.Products.Where(predicate).AsQueryable();   
        }
    }
}
