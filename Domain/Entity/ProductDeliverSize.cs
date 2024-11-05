using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductDeliverSize
    {
        public int Id { get; set; }
        public int ProductSizeId { get; set; }
        public int ProductDeliverId { get; set; }

        public ProductSize ProductSize { get; set; }
        public ProductDeliver ProductDeliver { get; set; }
    }
}
