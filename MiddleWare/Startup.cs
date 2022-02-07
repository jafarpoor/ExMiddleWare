using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiddleWare.MiddleWare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare
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
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            ////})

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("welcome faezehhhhhhh");
            //});

            //app.Use(async (context , next) =>
            //{
            //    await context.Response.WriteAsync("welcome faezehhhhhhh");
            //    await next();
            //});
            //app.Run(MethodMiddleWare);
            app.UseMiddlewareCiruiting();
        //    app.UseMiddlewareContetnt();
            //    app.UseMiddleware<MiddlewareContetnt>();

        }

        public Task MethodMiddleWare(HttpContext context)
        {
            return context.Response.WriteAsync("welcome faezehhhhhhh");
        }
    }
}
