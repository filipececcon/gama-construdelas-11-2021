using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class GetAllProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal UnitValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
