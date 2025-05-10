using CleanArchitecture.Domain.Abstractions;
using Microsoft.AspNetCore.Diagnostics;

namespace CleanArchitecture.WebAPI.Middlewares;

public sealed class MyExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        var exType = exception.GetType();
        var resType = typeof(ArgumentException);

        if (exType == resType)
        {
            httpContext.Response.StatusCode = 405;
        }
        await httpContext.Response.WriteAsJsonAsync(Result<string>.Failure(exception.Message));
        return true;
    }
}
