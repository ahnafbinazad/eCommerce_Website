using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_website.Model
{
    public class AppUser : IdentityUser
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
    }
}
