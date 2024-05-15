
using Database.Contexts;
using JobFinderPractic.DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace JobFinderPractic.Registers;

public static class ServiceRegistration
{
    public static void AddDbContextServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    }

    public static void AddRepositoryServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IGenericRepository<Job>, GenericRepository<Job>>();
    }

    public static void AddIdentityConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddIdentity<AppUser, IdentityRole<int>>().AddEntityFrameworkStores<AppDBContext>().AddDefaultTokenProviders();
    }
}
