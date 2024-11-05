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
    public class ProductAdtConfiguration : IEntityTypeConfiguration<ProductAdt>
    {
        public void Configure(EntityTypeBuilder<ProductAdt> builder)
        {
            builder.HasOne(pa => pa.Product)
                   .WithMany(p => p.ProductAdts)
                   .HasForeignKey(pa => pa.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pa => pa.AdType)
                   .WithMany(pat => pat.ProductAdts)
                   .HasForeignKey(pa => pa.AdTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(pa => pa.AdtPrices)
                   .WithOne(pap => pap.ProductAdt)
                   .HasForeignKey(pap => pap.ProductAdtId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
