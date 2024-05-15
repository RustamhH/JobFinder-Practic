using Database.Entities.Abstracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities.Concretes
{
    public class AppUser : IdentityUser<int>
    {
        public string FullName { get; set; }


        // Navigation property
        public ICollection<Job> Jobs { get; set; }
    }
}
