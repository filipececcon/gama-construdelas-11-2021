using System;
using Construdelas.OrderSystem.Domain.Shared.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Domain.Shared.Handlers
{
    public abstract class Handler<TEntity, TRequest, TResponse> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> repository;

        public abstract TResponse Handle(TRequest request);
    }
}
