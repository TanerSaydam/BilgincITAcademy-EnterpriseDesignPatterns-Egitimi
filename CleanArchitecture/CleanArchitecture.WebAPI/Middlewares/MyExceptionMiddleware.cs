
using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.WebAPI.Middlewares;

public class MyExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(Result<string>.Failure(ex.Message));
        }
    }
}
