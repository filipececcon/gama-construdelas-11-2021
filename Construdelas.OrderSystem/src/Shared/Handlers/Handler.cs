using System;
namespace Construdelas.OrderSystem.Domain.Shared.Handlers
{
    public abstract class Handler<TRequest, TResponse>
    {
        public abstract TResponse Handle(TRequest request);
    }
}
