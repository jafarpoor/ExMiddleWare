using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare.MiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareCiruiting
    {
        private readonly RequestDelegate _next;

        public MiddlewareCiruiting(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            await _next(httpContext);
            if (httpContext.Request.Headers["User-Agent"].Any(p => p.ToLower().Contains("Firefox"))) ;
            {
                httpContext.Response.StatusCode = 403;
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareCiruitingExtensions
    {
        public static IApplicationBuilder UseMiddlewareCiruiting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareCiruiting>();
        }
    }
}
