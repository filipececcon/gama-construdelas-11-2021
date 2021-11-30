using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;

namespace Construdelas.OrderSystem.Application.Queries.Interfaces
{
    public interface IGetAllOrderQuery : IHandler<GetAllOrderRequest, IQueryable<GetAllOrderResponse>>
    {
    }
}
