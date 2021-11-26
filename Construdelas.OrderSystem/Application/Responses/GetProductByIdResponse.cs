using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class GetProductByIdResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal UnitValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
