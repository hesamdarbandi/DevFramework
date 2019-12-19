using System;
using DevFramework.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DevFramework.Api.Infra.Exceptions
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {                            
                  context.HttpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                  context.Result = new JsonResult(new AppDomainError(context)); 
            }
        }
    }
}
