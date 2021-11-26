using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class UpdateProductRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal UnitValue { get; set; }
    }
}
