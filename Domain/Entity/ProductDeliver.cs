using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductDeliver
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product Product { get; set; }
        public ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; }
    }

}
