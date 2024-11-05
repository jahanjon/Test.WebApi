using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductGroupId { get; set; }
        public int WorkTypeId { get; set; }
        public int ProductType { get; set; }
        public string CopyCount { get; set; }
        public float MinPrice { get; set; }
        public float Price { get; set; }
        public bool IsCalculatePrice { get; set; }
        public float MaxPage { get; set; }
        public float MinPage { get; set; }
        public float MinWidth { get; set; }
        public float MaxWidth { get; set; }
        public float MinLength { get; set; }
        public float MaxLength { get; set; }
        public float PrintMargin { get; set; }
        public bool IsCheckFile { get; set; }

        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductMaterial> ProductMaterials { get; set; }
        public ICollection<ProductDeliver> ProductDelivers { get; set; }
        public ICollection<ProductAdt> ProductAdts { get; set; }
        public ICollection<ProductJeId> ProductJeIds { get; set; }
    }

}
