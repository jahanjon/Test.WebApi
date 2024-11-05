using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductJeId
    {
        public int ProductId { get; set; }
        public int JeId { get; set; }

        public Product Product { get; set; }
    }
}
