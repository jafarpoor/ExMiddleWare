using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareService
    {
        private readonly RequestDelegate _next;

        public MiddlewareService(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareServiceExtensions
    {
        public static IApplicationBuilder UseMiddlewareService(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareService>();
        }
    }
}
