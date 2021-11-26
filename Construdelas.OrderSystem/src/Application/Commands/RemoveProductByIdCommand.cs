using System;
using System.Linq;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Infra.Data.Repositories;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class RemoveProductByIdCommand : Handler<RemoveProductByIdRequest, RemoveProductByIdResponse>
    {
        public override RemoveProductByIdResponse Handle(RemoveProductByIdRequest request)
        { 
            var product = ProductRepository.Products.Single(x => x.Id == request.Id);

            ProductRepository.Products.Remove(product);

            return new RemoveProductByIdResponse();
        }
    }
}
