using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Areas.Reader.Models;
using CoreLibrary.Helper;
using CoreLibrary.Helper.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EBookContext>(options =>
            {
                // add connect string in here
                string connectionString = _configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            services.AddControllersWithViews().AddNewtonsoftJson(options =>
                        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<EBookContext>()
                .AddDefaultTokenProviders();

            // configure password when create identity user
            services.Configure<IdentityOptions>(config =>
            {
                config.Password.RequireUppercase = true;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireDigit = true;
                config.Password.RequiredLength = 6;
            });

            // binding config email
            services.Configure<SMTPConfigModel>(_configuration.GetSection("SMTPConfig"));

            // redirectly when the action have attribute authorize
            services.ConfigureApplicationCookie(configure =>
            {
                configure.LoginPath = _configuration.GetValue(typeof(string), "Application:LoginPath").ToString();
            });

            services.AddScoped<IUserClaimsPrincipalFactory<User>, AppUserClaimsPrincipalFactory>();

            services.AddScoped<EmailService>();
            services.AddScoped<UserService>();
            services.AddScoped<LinkService>();
            services.AddScoped<TextService>();
            services.AddScoped<ServerUrlService>();

            services.AddDistributedMemoryCache();

            services.AddSession(configure =>
            {
                configure.IdleTimeout = TimeSpan.FromMinutes(30);
                configure.Cookie.HttpOnly = true;
                configure.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");               

                //endpoints.MapAreaControllerRoute(
                //    name: "default",
                //    areaName: "reader",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
