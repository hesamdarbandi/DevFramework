using System;
using System.Collections.Generic;

namespace DevFramework.Core.Infrastructure.Domain
{
    public interface IBaseEntityWithTypeId<T>
    {
        T Id { get; set; }
    }
}