using Application.Common.DTOs.ErrorDTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Serilog;
using System.Net;

namespace API.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (context != null)
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.ContentType = "application/json";

                        var errorResponse = new ErrorDetailsDTO
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message
                        };

                        Log.Error(contextFeature.Error, contextFeature.Error.Message);

                        await context.Response.WriteAsync(errorResponse.ToString());
                    }
                });
            });
        }
    }
}
