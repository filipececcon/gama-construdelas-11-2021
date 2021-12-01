using System;
using Construdelas.OrderSystem.Application.Commands.interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class RemoveOrderByIdCommand : CommandBase<Order>, IRemoveOrderByIdCommand
    {
        public RemoveOrderByIdCommand(IRepository<Order> repository) : base(repository)
        {
        }

        public RemoveOrderByIdResponse Handle(RemoveOrderByIdRequest request)
        {
            repository.Remove(request.Id);

            repository.Save();

            return new RemoveOrderByIdResponse();
        }
    }
}
