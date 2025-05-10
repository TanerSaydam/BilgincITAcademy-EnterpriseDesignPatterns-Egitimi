using CleanArchitecture.Application.Auth;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.WebAPI.Endpoints;

public static class AuthModule
{
    public static IEndpointRouteBuilder MapAuth(this IEndpointRouteBuilder builder)
    {
        var app = builder.MapGroup("auth");

        app.MapPost("login",
            async (
                LoginCommand request,
                ISender sender,
                CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return Results.Ok(res);
            })
            .Produces<TokenResponse>();

        return app;
    }
}
