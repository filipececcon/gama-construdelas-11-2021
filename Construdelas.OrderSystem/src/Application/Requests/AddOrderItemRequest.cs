using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class AddOrderItemRequest
    {
        public Guid OrderId { get; set; }
        
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}

