using Construdelas.OrderSystem.Application.Queries.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetByIdOrderItemQuery : IGetByIdOrderItemQuery
    {
        private readonly IRepository<OrderItem> _repository;

        public GetByIdOrderItemQuery(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }

        public GetByIdOrderItemResponse Handle(GetByIdOrderItemRequest request)
        {
            var orderItem = _repository.GetById(request.Id);

            return new GetByIdOrderItemResponse()
            {
                Id = orderItem.Id,
                ProductName = orderItem.Product.Name,
                ProductUnitValue = orderItem.Product.UnitValue,
                Quantity = orderItem.Quantity,
                Subtotal = orderItem.GetSubtotal()
            };
        }
    }
}
