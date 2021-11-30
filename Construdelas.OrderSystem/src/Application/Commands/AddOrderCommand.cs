using System;
using Construdelas.OrderSystem.Application.Commands.interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddOrderCommand : CommandBase<Order>, IAddOrderCommand
    {
        public AddOrderCommand(IRepository<Order> repository) : base(repository)
        {
        }

        public AddOrderResponse Handle(AddOrderRequest request)
        {
            var order = new Order();

            repository.Add(order);

            return new AddOrderResponse() { Id = order.Id, CreatedAt = order.CreatedAt };
        }
    }
}
