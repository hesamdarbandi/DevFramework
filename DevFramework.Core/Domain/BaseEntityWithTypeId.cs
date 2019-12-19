using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevFramework.Core.Infrastructure.Domain
{
    public abstract class BaseEntityWithTypeId<T> : IBaseEntityWithTypeId<T>
    {
       public BaseEntityWithTypeId()
        {
            CreateOn = DateTime.Now;
        }

        [Key]
        public T Id { get; set; }
        public DateTime CreateOn { get; set; }
    }
}