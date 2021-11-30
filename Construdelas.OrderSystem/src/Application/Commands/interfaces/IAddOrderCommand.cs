using System;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;

namespace Construdelas.OrderSystem.Application.Commands.interfaces
{
    public interface IAddOrderCommand : IHandler<AddOrderRequest, AddOrderResponse>
    {
    }
}
