using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControllerLogic.Public.Product.DTOs
{
    public class ProductDeliverDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<ProductDeliverSizeDto> ProductDeliverSizes { get; set; }
    }
}
