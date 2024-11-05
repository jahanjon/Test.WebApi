using Application.ControllerLogic.Public.Product.DTOs;
using Application.Core;
using AutoMapper;
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
    public class GetProduct
    {
        public class Query : IRequest<Result<GetProductDto>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<GetProductDto>>
        {
            private readonly ApplicationDbContext db;
            private readonly IMapper mapper;

            public Handler(ApplicationDbContext db, IMapper mapper)
            {
                db = db;
                mapper = mapper;
            }

            public async Task<Result<GetProductDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var product = await db.Products
                    .Include(p => p.ProductSizes)
                    .Include(p => p.ProductMaterials)
                    .Include(p => p.ProductDelivers)
                    .FirstOrDefaultAsync(x => x.Id == request.Id);

                if (product == null)
                {
                    return Result<GetProductDto>.Failure(-404, "محصول مورد نظر یافت نشد.");
                }


                var productDto = mapper.Map<GetProductDto>(product);

                return Result<GetProductDto>.Success(200, "محصول مورد نظر یافت شد", productDto);
            }
        }
    }
}
