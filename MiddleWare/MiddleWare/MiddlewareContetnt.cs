using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare.MiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareContetnt
    {
        private readonly RequestDelegate _next;

        public MiddlewareContetnt(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("welcome faezehhhhhhh Joniiiiiiiii");
           // await  _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareContetntExtensions
    {
        public static IApplicationBuilder UseMiddlewareContetnt(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareContetnt>();
        }
    }
}
