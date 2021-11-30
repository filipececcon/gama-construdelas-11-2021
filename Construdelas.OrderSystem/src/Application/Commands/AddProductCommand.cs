using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddProductCommand : CommandBase<Product>, IAddProductCommand
    {
        public AddProductCommand(IRepository<Product> repository) : base(repository)
        {
            
        }

        public AddProductResponse Handle(AddProductRequest request)
        {
            var product = new Product(request.Name, request.UnitValue);

            repository.Add(product);

            return new AddProductResponse()
            {
                Id = product.Id,
                Name = product.Name,
                CreatedAt = product.CreatedAt
            };
        }
    }
}
