using System;
using Construdelas.OrderSystem.Domain.Shared.Entities;

namespace Construdelas.OrderSystem.Domain.OrderManagement.Entities
{
    public class OrderItem : Entity
    {
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        private OrderItem(){}

        public OrderItem(Guid productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }


        //são para os relacionamentos
        public Product Product { get; set; }
        public Guid ProductId { get; set; }


        public Order Order { get; set; }
        public Guid OrderId { get; set; }
    }
}
