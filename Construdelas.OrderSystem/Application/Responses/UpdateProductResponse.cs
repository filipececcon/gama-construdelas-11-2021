using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class UpdateProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal UnitValue { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
