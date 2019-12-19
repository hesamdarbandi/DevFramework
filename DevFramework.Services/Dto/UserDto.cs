using System;
using DevFramework.Domain.Model;

namespace DevFramework.Service.Dto
{
    public class UserDto : ImappedFrom<User>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
