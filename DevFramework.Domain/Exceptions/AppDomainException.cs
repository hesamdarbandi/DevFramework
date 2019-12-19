using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace DevFramework.Domain.Exceptions
{
   public class AppDomainException : Exception
   {
       public int StatusCode { get; set; }
       public string SourceName { get; set; }

       public AppDomainException()
       {
       }

       public AppDomainException(string message)
           : this(message, HttpStatusCode.BadRequest)
       {
       }

       public AppDomainException(string message, HttpStatusCode statusCode)
           : this(message, statusCode, string.Empty)
       {
       }

       public AppDomainException(string message, HttpStatusCode statusCode, string sourceName)
           : base(message)
       {
           StatusCode = statusCode.GetHashCode();
           SourceName = sourceName ?? string.Empty;
       }
   }

   public class AppDomainError
   {
       public int StatusCode { get; set; }
       public string Message { get; set; }
       public string SourceName { get; set; }
       public List<ValidationError> Errors { get; set; }

       public AppDomainError(string message, string sourceName, int statusCode)
       {
           StatusCode = statusCode;
           Message = message;
           SourceName = sourceName ?? string.Empty;
       }

        public AppDomainError(ActionExecutingContext context)
        {
            Message = "Validation Error";
            StatusCode = StatusCodes.Status422UnprocessableEntity;
            SourceName = context.RouteData.Values["controller"].ToString() + " " + context.RouteData.Values["action"].ToString();
            Errors = context.ModelState.Keys
                  .SelectMany(key => context.ModelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
                  .ToList();
        }
   }

   public class ValidationError
   {
       [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
       public string Field { get; }
       public string Message { get; }

       public ValidationError(string field, string message)
       {
           Field = field != string.Empty ? field : null;
           Message = message;
       }
   }
}
