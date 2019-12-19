namespace DevFramework.Api.Infra.Exceptions
{
    using DevFramework.Domain.Exceptions;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;
    using System.Net;

    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment env;
        private readonly ILogger<HttpGlobalExceptionFilter> logger;

        public HttpGlobalExceptionFilter(IHostingEnvironment env, ILogger<HttpGlobalExceptionFilter> logger)
        {
            this.env = env;
            this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            logger.LogError(new EventId(context.Exception.HResult),
                context.Exception,
                context.Exception.Message);

              if (context.Exception is AppDomainException)
              {
                  var domainException = context.Exception as AppDomainException;
                  var error = new AppDomainError(domainException.Message,domainException.SourceName,domainException.StatusCode); 
                  context.Result = new JsonResult(error);
                  context.HttpContext.Response.StatusCode = domainException.StatusCode;
                  return;
              }
              var json = new JsonErrorResponse
                {
                    Messages = new[] { context.Exception.Message }
                };

                if (env.IsDevelopment())
                {
                    json.DeveloperMessage = context.Exception.InnerException;
                }
                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;                
            }

        private class JsonErrorResponse
        {
            public string[] Messages { get; set; }
            public object DeveloperMessage { get; set; }
        }
    }
}