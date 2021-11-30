using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class RemoveOrderItemByIdCommand : CommandBase<OrderItem>, IRemoveOrderItemByIdCommand
    {
        public RemoveOrderItemByIdCommand(IRepository<OrderItem> repository): base(repository)
        {
            
        }

        public RemoveOrderItemResponse Handle(RemoveOrderItemRequest request)
        {
            repository.Remove(request.Id);

            return new RemoveOrderItemResponse();
        }
    }
}