using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi
{
    [RequireHttps]
    [Route("[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

        private IMediator _mediator;
        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result.ResultCode == 200)
                return Ok(result);
            if (result.ResultCode == 400 || result.ResultCode == -400)
                return BadRequest(result);
            if (result.ResultCode == 404 || result.ResultCode == -404)
                return NotFound(result);
            if (result.ResultCode == -1400)
                return BadRequest(result);
            return BadRequest(result);
        }

        protected ActionResult CommandResult<T>(Result<T> result)
        {
            if (result.ResultCode == 200)
                return Ok(ResultForNullValues.Create(result));
            if (result.ResultCode == 400 || result.ResultCode == -400)
                return BadRequest(ResultForNullValues.Create(result));
            if (result.ResultCode == 404 || result.ResultCode == -404)
                return NotFound(ResultForNullValues.Create(result));
            if (result.ResultCode == -1400)
                return BadRequest(ResultForNullValues.Create(result));
            return BadRequest(ResultForNullValues.Create(result)); ;
        }
    }
}
