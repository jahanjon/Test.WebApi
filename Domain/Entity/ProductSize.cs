using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductSize
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public Product Product { get; set; }
        public ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; }
    }

}
