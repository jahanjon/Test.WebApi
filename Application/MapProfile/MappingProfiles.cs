using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MapProfile
{
    using Application.ControllerLogic.Public.Product.DTOs;
    using AutoMapper;
    using Domain.Entity;

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProductDto, Product>();
            CreateMap<ProductSizeDto, ProductSize>();
            CreateMap<ProductMaterialDto, ProductMaterial>();
            CreateMap<ProductDeliverDto, ProductDeliver>();
            CreateMap<ProductDeliverSizeDto, ProductDeliverSize>();
            CreateMap<Product, ProductDto>();
        }
    }

}
