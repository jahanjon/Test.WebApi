using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductAdtPrice
    {
        public int Id { get; set; }
        public int ProductAdtId { get; set; }
        public float Price { get; set; }

        public ProductAdt ProductAdt { get; set; }
    }

}
