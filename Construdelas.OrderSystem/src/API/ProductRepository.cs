using System;
using System.Collections.Generic;

namespace Construdelas.OrderSystem.Services.API
{
    public static class ProductRepository
    {
        public static Dictionary<Guid, string> Products { get; set; } = new Dictionary<Guid, string>();

    }
}
