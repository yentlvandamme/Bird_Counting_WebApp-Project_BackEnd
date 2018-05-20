using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BirdCounting.Web.Data;
using BirdCounting.Web.Services;
using BirdCounting.Models;
using BirdCounting.Repositories;
using BirdCounting.Services;

namespace BirdCounting.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add Repositories
            services.AddScoped<IBirdRepo, BirdRepo>();
            services.AddScoped<IEventRepo, EventRepo>();
            services.AddScoped<ICountLogRepo, CountLogRepo>();
            services.AddScoped<IRegionRepo, RegionRepo>();

            // Add Services
            services.AddScoped<IBirdService, BirdService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<ICountLogService, CountLogService>();
            services.AddScoped<IRegionService, RegionService>();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Bird}/{action=Index}/{id?}");
            });
        }
    }
}
