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
    public class ProductSizeConfiguration : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.HasMany(ps => ps.ProductDeliverSizes)
                   .WithOne(pds => pds.ProductSize)
                   .HasForeignKey(pds => pds.ProductSizeId);
        }
    }

}
