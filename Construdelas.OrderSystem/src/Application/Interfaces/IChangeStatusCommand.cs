using System;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Entities;
using Construdelas.OrderSystem.Domain.Shared.Handlers;

namespace Construdelas.OrderSystem.Application.Interfaces
{
    public interface IChangeStatusCommand<TEntity> : IHandler<ChangeStatusRequest, ChangeStatusResponse> where TEntity : Entity
    {
        
    }
}
