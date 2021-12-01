using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class UpdateOrderItemCommand : CommandBase<OrderItem>, IUpdateOrderItemCommand
    {
        private readonly IRepository<Product> _productRepository;

        public UpdateOrderItemCommand(IRepository<OrderItem> repository, IRepository<Product> productRepository) : base(repository)
        {   
            _productRepository = productRepository;
        }

        public UpdateOrderItemResponse Handle(UpdateOrderItemRequest request)
        {
            var orderItem = repository.GetById(request.Id);

            orderItem.Quantity = request.Quantity;
            orderItem.ProductId = request.ProductId;

            var product = _productRepository.GetById(request.ProductId);

            repository.Save();

            return new UpdateOrderItemResponse()
            {
                ProductId = orderItem.Id,
                Quantity = orderItem.Quantity,
                Subtotal = product.UnitValue * request.Quantity
            };

        }
    }
}
