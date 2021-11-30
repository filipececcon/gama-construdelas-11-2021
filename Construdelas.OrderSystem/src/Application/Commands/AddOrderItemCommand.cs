using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddOrderItemCommand : CommandBase<OrderItem>, IAddOrderItemCommand
    {
        private readonly IRepository<Product> _productRepository;

        public AddOrderItemCommand(IRepository<OrderItem> repository, IRepository<Product> productRepository) : base(repository)
        {
            _productRepository = productRepository;
        }

        public AddOrderItemResponse Handle(AddOrderItemRequest request)
        {
            var orderItem = new OrderItem(request.ProductId, request.Quantity);

            repository.Add(orderItem);

            var product = _productRepository.GetById(request.ProductId);

            return new AddOrderItemResponse()
            {
                Id = orderItem.Id,
                Subtotal = product.UnitValue * request.Quantity
            };
            
        }
    }
}
