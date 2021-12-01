using System;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Construdelas.OrderSystem.Infra.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("TB_ORDER_ITEM");

            //mapeamete de relacionamento 1 para muitos
            builder
                .HasOne(i => i.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(i => i.OrderId);
        }
    }
}
