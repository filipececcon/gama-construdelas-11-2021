using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;


namespace Construdelas.OrderSystem.Application.Commands
{
    public class RemoveProductByIdCommand : IRemoveProductByIdCommand
    {
        private readonly IProductRepository _repository;

        public RemoveProductByIdCommand(IProductRepository repository)
        {
            _repository = repository;
        }

        public RemoveProductByIdResponse Handle(RemoveProductByIdRequest request)
        { 
            var product = _repository.GetById(request.Id);

            product.IsActive = false;

            _repository.Update(product);

            return new RemoveProductByIdResponse() { IsActive = product.IsActive };
        }
    }
}
