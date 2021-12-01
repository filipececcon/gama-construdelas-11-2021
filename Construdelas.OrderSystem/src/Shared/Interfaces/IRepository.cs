using System;
using System.Linq;
using System.Linq.Expressions;
using Construdelas.OrderSystem.Domain.Shared.Entities;

namespace Construdelas.OrderSystem.Domain.Shared.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        TEntity GetById(Guid id, params string[] includes);
        void Update(TEntity product);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, params string[] includes);
        void Remove(Guid id);
        void Save();
    }
}
