using System;
using System.Collections.Generic;
using System.Linq;

namespace Construdelas.OrderSystem.Domain.OrderManagement.Entities
{
    public class Order : Entity
    {
        public List<OrderItem> Items { get;set;}
        public decimal Total { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.Subtotal);
        }
    }
}
