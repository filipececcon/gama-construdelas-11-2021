using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public decimal UnitValue { get; set; }
    }
}
