using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MyCustomMiddleware
    {
        private RequestDelegate _next;
        private ILogger _logger;
        public MyCustomMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger("MyCustomLogger");
            _logger.LogInformation("Info Logged");
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
            await context.Response.WriteAsync("Hi From MW");
        }
    }

    public static class MyCustomerMiddlewareExtension
    {
        public static IApplicationBuilder MyCustomerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleware>();
        }
    }
}
