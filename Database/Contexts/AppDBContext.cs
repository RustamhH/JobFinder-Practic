using Database.Configurations;
using Database.Entities.Concretes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Database.Contexts
{
    public class AppDBContext:IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new JobConfiguration());

        }



    }
}
