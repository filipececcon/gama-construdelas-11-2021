using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class AddOrderItemResponse
    {
        public Guid Id { get; set; }

        public decimal Subtotal { get; set; }
    }
}
