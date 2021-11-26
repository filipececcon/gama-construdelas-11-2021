using System;
using Construdelas.OrderSystem.Domain.Shared.Entities;

namespace Construdelas.OrderSystem.Domain.OrderManagement.Entities
{
    public class Product : Entity
    {  
        public string Name { get; set; }
        public decimal UnitValue { get; set; }

        public Product(string name, decimal unitValue)
        {
            Name = name;
            UnitValue = unitValue;
        }
    }
}
