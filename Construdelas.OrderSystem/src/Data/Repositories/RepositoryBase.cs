using System;
using System.Linq;
using System.Linq.Expressions;
using Construdelas.OrderSystem.Domain.Shared.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Construdelas.OrderSystem.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            _context.SaveChanges();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity product)
        {
            product.UpdatedAt = DateTime.Now;

            _context.Set<TEntity>().Update(product);

            _context.SaveChanges();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null
                ? _context.Set<TEntity>().AsQueryable()
                : _context.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public void Remove(Guid id)
        {
            var entity = GetById(id);

            _context.Set<TEntity>().Remove(entity);

            _context.SaveChanges();
        }
    }
}
