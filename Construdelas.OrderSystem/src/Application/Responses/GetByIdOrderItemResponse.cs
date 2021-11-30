using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class GetByIdOrderItemResponse
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductUnitValue { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}
