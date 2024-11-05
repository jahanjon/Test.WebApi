using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace Application.Core
{
     public static class ModelStateExtension
    {
        public static Microsoft.AspNetCore.Mvc.ObjectResult InvalidModelStateResponse(ModelStateDictionary modelState)
            => new BadRequestObjectResult(Result<string>.Failure(-400,
                modelState.Values.First()?.Errors.First().ErrorMessage));

    }
}
