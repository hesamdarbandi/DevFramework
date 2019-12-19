// using System;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Filters;
// using System.Linq;
// using System.Security.Claims;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.Extensions.DependencyInjection;
// using DevFramework.Api.Infrastructure.BaseRepository;
// using DevFramework.Api.Domain.Model;
// using System.Net;
// using DevFramework.Api.Infrastructure.Exceptions;

// namespace DevFramework.Api.Infrastructure.Filters
// {
//     public class UserAccessFilter : ActionFilterAttribute
//     {
//         public override void OnActionExecuting(ActionExecutingContext context)
//         {
//             if (context.Controller.GetType().CustomAttributes.Any(c => c.AttributeType == typeof(AllowAnonymousAttribute)))
//             {
//                 return;
//             }

//             var action = (string)context.RouteData.Values["action"];
//             if (!string.IsNullOrEmpty(action) && context.Controller.GetType().GetMethod(action).CustomAttributes.Any(c => c.AttributeType == typeof(AllowAnonymousAttribute)))
//             {
//                 return;
//             }

//             var user = context.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "id").ToString();
//             if (!int.TryParse(user, out var userId))
//             {
//                 context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
//                 context.Result = new JsonResult(new AppDomainError("not Authorize", "access Filter", (int)HttpStatusCode.Unauthorized));
//             }

//             var unitOfwork = context.HttpContext.RequestServices.GetService<IUnitOfWork>();
//             var userRepository = unitOfwork.GetRepository<User>();
//             // var user = userRepository.GetFirstOrDefaultAsync
//             // if (context.HttpContext.Request.Method == "HttpPost")
//             // {

//             // }
//         }
//     }
// }
