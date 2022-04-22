using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentRegistration.Areas.Identity.Data;
using StudentRegistration.Data;

[assembly: HostingStartup(typeof(StudentRegistration.Areas.Identity.IdentityHostingStartup))]
namespace StudentRegistration.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDBContextConnection")));

                services.AddDefaultIdentity<StudentRegistrationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AuthDBContext>();
            });
        }
    }
}