using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControllerLogic.Public.Product.DTOs
{
    public class ProductDto
    {
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
        public List<ProductSizeDto> ProductSizes { get; set; }
        public List<ProductMaterialDto> ProductMaterials { get; set; }
        public List<ProductDeliverDto> ProductDelivers { get; set; }
    }
}
