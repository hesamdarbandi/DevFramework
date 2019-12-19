
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DevFramework.Domain.Model
{
    public class User : IdentityUser<int>
    {        
        public List<Request> Requests { get; set; }
    }

    public class Role : IdentityRole<int>
    {
        public User User { get; set; }
    }

}