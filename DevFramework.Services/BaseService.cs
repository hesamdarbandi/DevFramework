using System;
using System.Net;
using DevFramework.Domain.Exceptions;
using Microsoft.Extensions.Options;
using DevFramework.Domain.Config;

namespace DevFramework.Service
{
    public abstract class BaseService
    {
        protected readonly IOptionsSnapshot<AppSetting> _setting;
        public BaseService(IOptionsSnapshot<AppSetting> setting) => _setting = setting;
        protected virtual void RaiseError(string message)
        {
            RaiseError(message, HttpStatusCode.BadRequest, this.GetType().Name);
        }

        protected virtual void RaiseError(string message, HttpStatusCode statusCode)
        {
            RaiseError(message, statusCode, this.GetType().Name);
        }

        protected virtual void RaiseError(string message, HttpStatusCode statusCode, string sourceName)
        {
            var appException = new AppDomainException(message, statusCode, sourceName);
            throw appException;
        }
    }
}
