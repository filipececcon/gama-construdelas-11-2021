﻿using System;
using System.Collections.Generic;
using System.Linq;
using Construdelas.OrderSystem.Domain.Shared.Entities;

namespace Construdelas.OrderSystem.Domain.OrderManagement.Entities
{
    public class Order : Entity
    {
        public List<OrderItem> Items { get; set; }
        public decimal Total { get; set; }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.Subtotal);
        }
    }
}
