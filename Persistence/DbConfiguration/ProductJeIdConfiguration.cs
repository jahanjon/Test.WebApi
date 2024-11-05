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
    public class ProductJeIdConfiguration : IEntityTypeConfiguration<ProductJeId>
    {
        public void Configure(EntityTypeBuilder<ProductJeId> builder)
        {
            builder.HasKey(pj => new { pj.ProductId, pj.JeId });

            builder.HasOne(pj => pj.Product)
                   .WithMany(p => p.ProductJeIds)
                   .HasForeignKey(pj => pj.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
