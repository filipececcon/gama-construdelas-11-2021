using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class AddProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
