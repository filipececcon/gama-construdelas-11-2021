using System;
using Construdelas.OrderSystem.Domain.Shared.Entities;

namespace Construdelas.OrderSystem.Domain.OrderManagement.Entities
{
    public class OrderItem : Entity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        private OrderItem(){}

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal GetSubtotal()
        {
            return Quantity * Product.UnitValue;
        }
    }
}
