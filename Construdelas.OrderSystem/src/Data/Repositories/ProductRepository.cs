using System;
using System.Collections.Generic;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;

namespace Construdelas.OrderSystem.Infra.Data.Repositories
{
    public class ProductRepository
    {
        public static List<Product> Products { get; set; } = new List<Product>();
    }
}
