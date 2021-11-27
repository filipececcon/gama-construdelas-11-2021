using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Handlers;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class RemoveProductByIdCommand : IHandler<RemoveProductByIdRequest, RemoveProductByIdResponse>
    {
        private readonly ProductRepository _repository;

        public RemoveProductByIdCommand(ProductRepository repository)
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
