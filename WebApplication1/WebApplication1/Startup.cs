using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ExtenMiddleware;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/macdinh", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            app.UseMiddleware<ExtenMiddle>();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World1");
                await next.Invoke();
                await context.Response.WriteAsync("Hello World2");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World3");
                await next.Invoke();
                await context.Response.WriteAsync("Hello World4");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World5");
            });

            app.UseMiddleSimple();

        }
    }
}
