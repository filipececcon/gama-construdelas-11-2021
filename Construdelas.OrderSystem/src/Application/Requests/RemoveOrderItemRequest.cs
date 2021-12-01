using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class RemoveOrderItemRequest
    {
        public RemoveOrderItemRequest(Guid orderItemId, Guid orderId)
        {
            OrderItemId = orderItemId;
            OrderId = orderId;
        }

        public Guid OrderItemId { get; set; }

        public Guid OrderId { get; set; }
    }
}
