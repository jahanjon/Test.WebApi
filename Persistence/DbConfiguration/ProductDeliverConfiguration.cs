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
    public class ProductDeliverConfiguration : IEntityTypeConfiguration<ProductDeliver>
    {
        public void Configure(EntityTypeBuilder<ProductDeliver> builder)
        {
            builder.HasMany(pd => pd.ProductDeliverSizes)
                   .WithOne(pds => pds.ProductDeliver)
                   .HasForeignKey(pds => pds.ProductDeliverId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
