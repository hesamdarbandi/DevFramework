using System;
using System.Linq;
using AutoMapper;
using DevFramework.Api.Infra.Helpers;
using DevFramework.Service.Dto;

namespace DevFramework.Api.Infra.Mapping
{
    public class AppMapping : Profile
    {    
        public AppMapping()
        {
            var types = Helper.GetApplicationTypes();
            var maps = (from type in types
                        from i in type.GetInterfaces()
                        where i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ImappedFrom<>)
                        && !type.IsAbstract && !type.IsInterface
                        select new
                        {
                            Source = i.GenericTypeArguments[0],
                            Dest = type
                        }).ToArray();
            foreach (var map in maps)
            {                            
                CreateMap(map.Source, map.Dest);
                CreateMap(map.Dest, map.Source);                
            }            
        }

    }
}
