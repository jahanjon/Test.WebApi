using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductMaterial
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public bool IsIsolated { get; set; }

        public Product Product { get; set; }
        public ICollection<ProductMaterialAttribute> ProductMaterialAttributes { get; set; }
    }

}
