using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistence.DbConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDeliverConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSizeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new ProductAdtConfiguration());
            modelBuilder.ApplyConfiguration(new ProductJeIdConfiguration());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<ProductDeliver> ProductDelivers { get; set; }
        public DbSet<ProductDeliverSize> ProductDeliverSizes { get; set; }
        public DbSet<ProductMaterialAttribute> ProductMaterialAttributes { get; set; }
        public DbSet<ProductPrintKind> ProductPrintKinds { get; set; }
        public DbSet<ProductAdt> ProductAdts { get; set; }
        public DbSet<ProductAdtPrice> ProductAdtPrices { get; set; }
        public DbSet<ProductAdType> ProductAdTypes { get; set; }
        public DbSet<ProductJeId> ProductJeIds { get; set; }
    }

}
