using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DbConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.ProductSizes)
                   .WithOne(ps => ps.Product)
                   .HasForeignKey(ps => ps.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.ProductMaterials)
                   .WithOne(pm => pm.Product)
                   .HasForeignKey(pm => pm.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.ProductDelivers)
                   .WithOne(pd => pd.Product)
                   .HasForeignKey(pd => pd.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
