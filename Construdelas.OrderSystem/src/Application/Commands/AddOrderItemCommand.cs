using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Commands;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class AddOrderItemCommand : CommandBase<Order>, IAddOrderItemCommand
    {
        private IRepository<Product> _productRepository;
        private IRepository<OrderItem> _orderItemRepository;

        public AddOrderItemCommand(IRepository<Order> repository, IRepository<Product> productRepository, IRepository<OrderItem> orderItemRepository) : base(repository)
        {
            _productRepository = productRepository;
            _orderItemRepository = orderItemRepository;
        }

        public AddOrderItemResponse Handle(AddOrderItemRequest request)
        {
            var product = _productRepository.GetById(request.ProductId);

            var order = repository.GetById(request.OrderId);

            var orderItem = new OrderItem(request.ProductId, request.Quantity)
            {
                OrderId = order.Id,
                Subtotal = product.UnitValue * request.Quantity
            };

            _orderItemRepository.Add(orderItem);
            
            order.Total += orderItem.Subtotal;

            repository.Update(order);

            repository.Save();

            return new AddOrderItemResponse()
            {
                Id = orderItem.Id,
                Subtotal = orderItem.Subtotal
            };
            
        }
    }
}
