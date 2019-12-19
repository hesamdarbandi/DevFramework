using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFramework.Api.Infra.Helpers
{
    public static class Helper
    {
              public static IEnumerable<Type> GetApplicationTypes()
        {            
            return typeof(Helper).Assembly.GetTypes().Where(t=> !t.IsAbstract).ToList();             
        }
    }
}