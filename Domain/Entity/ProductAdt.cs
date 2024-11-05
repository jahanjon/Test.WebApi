using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductAdt
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AdTypeId { get; set; }
        public bool IsIsolated { get; set; }

        public Product Product { get; set; }
        public ProductAdType AdType { get; set; }
        public ICollection<ProductAdtPrice> AdtPrices { get; set; }
    }
}
