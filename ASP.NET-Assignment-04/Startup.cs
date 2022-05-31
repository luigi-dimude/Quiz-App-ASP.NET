using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ASP.NET_Assignment_04.Models;
using Microsoft.EntityFrameworkCore;


namespace ASP.NET_Assignment_04
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
            services.AddRouting(options => {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

            // Add session to application. Set session time to 15 minutes
            services.AddMemoryCache();
            services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(11));

            services.AddControllersWithViews();

            services.AddDbContext<QuizContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("QuizContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "",
                   pattern: "{controller=Quiz}/{action=QuizQuestion}/questionIndex/{questionIndex}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
