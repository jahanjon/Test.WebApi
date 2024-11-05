using Application.ControllerLogic.Public.Product.DTOs;
using Application.Core;
using AutoMapper;
using Domain.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ControllerLogic.Public.Product
{
    public class CreateProduct
    {
        public class Command : IRequest<Result<Unit>>
        {
            public ProductDto Dto { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ApplicationDbContext db;
            private readonly IMapper mapper;

            public Handler(ApplicationDbContext context, IMapper mapper)
            {
                db = context;
                mapper = mapper;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {

                var product = new Domain.Entity.Product
                {
                    ProductGroupId = request.Dto.ProductGroupId,
                    WorkTypeId = request.Dto.WorkTypeId,
                    ProductType = request.Dto.ProductType,
                    CopyCount = request.Dto.CopyCount,
                    MinPrice = request.Dto.MinPrice,
                    Price = request.Dto.Price,
                    IsCalculatePrice = request.Dto.IsCalculatePrice,
                    MaxPage = request.Dto.MaxPage,
                    MinPage = request.Dto.MinPage,
                    MinWidth = request.Dto.MinWidth,
                    MaxWidth = request.Dto.MaxWidth,
                    MinLength = request.Dto.MinLength,
                    MaxLength = request.Dto.MaxLength,
                    PrintMargin = request.Dto.PrintMargin,
                    IsCheckFile = request.Dto.IsCheckFile,
                    ProductSizes = request.Dto.ProductSizes.Select(size => new ProductSize
                    {
                        ProductId = size.ProductId,
                        Width = size.Width,
                        Height = size.Height
                    }).ToList(),
                    ProductMaterials = request.Dto.ProductMaterials.Select(m => new ProductMaterial
                    {
                        Name = m.Name,
                        IsIsolated = m.IsIsolated,
                        ProductMaterialAttributes = new List<ProductMaterialAttribute>()
                    }).ToList(),
                    ProductDelivers = request.Dto.ProductDelivers.Select(d => new ProductDeliver
                    {
                        ProductId = d.ProductId,
                        Name = d.Name,
                        Price = d.Price
                    }).ToList()
                };

                db.Products.Add(product);
                await db.SaveChangesAsync(cancellationToken);

                return Result<Unit>.Success(200, "محصول با موفقیت ایجاد شد.");
            }


            ///////AUTO MAPPER
            //public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            //{
            //    try
            //    {

            //        if (request.Dto == null)
            //        {
            //            return Result<Unit>.Failure(-400, "اطلاعات محصول ارسال نشده است.");
            //        }


            //        var product = mapper.Map<Domain.Entity.Product>(request.Dto);
            //        if (product == null)
            //        {
            //            return Result<Unit>.Failure(-400, "عملیات مپ کردن محصول به درستی انجام نشد.");
            //        }


            //        db.Products.Add(product);
            //        await db.SaveChangesAsync(cancellationToken);

            //        return Result<Unit>.Success(200, "محصول با موفقیت ایجاد شد.");
            //    }
            //    catch (Exception ex)
            //    {

            //        return Result<Unit>.Failure(-500, $"خطای غیرمنتظره رخ داد: {ex.Message}");
            //    }
            //}
        }
    }
}

