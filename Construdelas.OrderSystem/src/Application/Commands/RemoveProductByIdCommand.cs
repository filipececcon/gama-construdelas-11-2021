using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class RemoveProductByIdCommand : CommandBase<Product>, IRemoveProductByIdCommand
    {
        public RemoveProductByIdCommand(IRepository<Product> repository) : base(repository)
        {
        }

        public RemoveProductByIdResponse Handle(RemoveProductByIdRequest request)
        { 
            var product = repository.GetById(request.Id);

            product.IsActive = false;

            repository.Update(product);

            return new RemoveProductByIdResponse() { IsActive = product.IsActive };
        }
    }
}
