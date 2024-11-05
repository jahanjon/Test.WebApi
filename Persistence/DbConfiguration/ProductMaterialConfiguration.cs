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
    public class ProductMaterialConfiguration : IEntityTypeConfiguration<ProductMaterial>
    {
        public void Configure(EntityTypeBuilder<ProductMaterial> builder)
        {
            builder.HasMany(pm => pm.ProductMaterialAttributes)
                   .WithOne(pma => pma.ProductMaterial)
                   .HasForeignKey(pma => pma.ProductMaterialId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
