using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class UpdateOrderItemRequest
    {        
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
