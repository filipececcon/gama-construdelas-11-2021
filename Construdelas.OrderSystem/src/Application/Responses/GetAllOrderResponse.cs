using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class GetAllOrderResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ItemsCount { get; set; }
        public decimal Total { get; set; }
    }
}
