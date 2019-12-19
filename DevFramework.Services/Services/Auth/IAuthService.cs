using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using DevFramework.Service.Dto;
using DevFramework.Core.Infrastructure.Model;

namespace DevFramework.Service
{
    public interface IAuthService
    {       
        Task<string> Login(UserDto user);        
    }
}