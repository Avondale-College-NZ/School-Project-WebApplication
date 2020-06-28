using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School_Project_WebApplication.Areas.Identity.Data;
using School_Project_WebApplication.Data;

[assembly: HostingStartup(typeof(School_Project_WebApplication.Areas.Identity.IdentityHostingStartup))]
namespace School_Project_WebApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SchoolProjectDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SchoolProjectDbContextConnection")));

                services.AddDefaultIdentity<UserApplication>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SchoolProjectDbContext>();
            });
        }
    }
}