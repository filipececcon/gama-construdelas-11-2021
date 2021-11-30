using System;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;

namespace Construdelas.OrderSystem.Application.Queries.Interfaces
{
    public interface IGetByIdOrderItemQuery : IHandler<GetByIdOrderItemRequest, GetByIdOrderItemResponse>
    {
    }
}
