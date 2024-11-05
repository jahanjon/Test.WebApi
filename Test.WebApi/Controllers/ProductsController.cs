using Application.ControllerLogic.Public.Product.DTOs;
using Application.ControllerLogic.Public.Product;
using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : BaseApiController
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductDto dto)
        {
            return HandleResult(await _mediator.Send(new CreateProduct.Command { Dto = dto }));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            return HandleResult(await Mediator.Send(new GetProduct.Query { Id = id }));
        }

    }
}
