using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProductMaterialAttribute
    {
        public int Id { get; set; }
        public int ProductMaterialId { get; set; }
        public int MaterialAttributeId { get; set; }

        public ProductMaterial ProductMaterial { get; set; }
    }

}
