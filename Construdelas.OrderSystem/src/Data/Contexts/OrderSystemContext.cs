using System;
using Microsoft.EntityFrameworkCore;

namespace Construdelas.OrderSystem.Infra.Data.Contexts
{
    public class OrderSystemContext : DbContext
    {

        public OrderSystemContext(DbContextOptions<OrderSystemContext> options) : base(options)
        {

        }

        


    }
}
