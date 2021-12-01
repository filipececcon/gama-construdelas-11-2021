using System;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Construdelas.OrderSystem.Infra.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TB_PRODUCT");

            builder
                .Property(x => x.CreatedAt)
                .HasColumnName("DT_CREATED")
                .IsRequired();
                    
        }
    }
}
