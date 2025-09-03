using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace OrderProductService.Api.Middlewares;

public class GlobalExceptionMiddleware(ProblemDetailsFactory problemDetailsFactory) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch
        {
            context.Response.Clear();
            context.Response.ContentType = "application/problem+json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            var problemDetails = problemDetailsFactory.CreateProblemDetails(
                context,
                statusCode: StatusCodes.Status500InternalServerError,
                title: "Internal Server Error",
                detail: "An unexpected error occurred.",
                instance: context.Request.Path
            );

            await context.Response.WriteAsJsonAsync(problemDetails);
        }
    }
}