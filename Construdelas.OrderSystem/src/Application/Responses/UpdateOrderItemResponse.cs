﻿using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class UpdateOrderItemResponse
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Subtotal { get; set; }
    }
}
