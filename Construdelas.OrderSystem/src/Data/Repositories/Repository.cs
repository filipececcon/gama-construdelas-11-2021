using System;
using System.Linq;
using System.Linq.Expressions;
using Construdelas.OrderSystem.Domain.Shared.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Construdelas.OrderSystem.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private OrderSystemContext _context;

        public Repository(OrderSystemContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);



            _context.Set<TEntity>().Where(x => x.CreatedAt > DateTime.Now).Select(c => c.CreatedAt);
            //_context.SaveChanges();
        }

        public TEntity GetById(Guid id, params string[] includes)
        {
            var db = _context.Set<TEntity>().AsNoTracking();

            foreach (var i in includes) {

                db = db.Include(i);
            }
            
            return db.SingleOrDefault(x => x.Id == id);
        }

        public void Update(TEntity product)
        {
            product.UpdatedAt = DateTime.Now;

            _context.Set<TEntity>().Update(product);

            //_context.SaveChanges();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, params string[] includes)
        {
            var db = _context.Set<TEntity>().AsNoTracking();

            foreach(var i in includes)
            {
                db = db.Include(i);
            }

            return predicate == null ? db.AsQueryable() : db.Where(predicate);
        }

        public void Remove(Guid id)
        {
            var entity = GetById(id);

            _context.Set<TEntity>().Remove(entity);

            //_context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
