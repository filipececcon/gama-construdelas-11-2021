using System;
namespace Construdelas.OrderSystem.Domain.Shared.Handlers
{
    public interface IHandler<TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
