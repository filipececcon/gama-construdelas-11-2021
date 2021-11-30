using System;
using Construdelas.OrderSystem.Domain.Shared.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Domain.Shared.Commands
{
    public abstract class CommandBase<TEntity> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> repository;

        protected CommandBase(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }
    }
}
