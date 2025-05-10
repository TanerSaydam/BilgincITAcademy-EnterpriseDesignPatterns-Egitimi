using CleanArchitecture.Application.Products;
using CleanArchitecture.Domain.Abstractions;
using MediatR;

namespace CleanArchitecture.WebAPI.Endpoints;

public static class ProductModule
{
    public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder builder)
    {
        var app = builder.MapGroup("products")
            .RequireRateLimiting("fixed");
        //.RequireAuthorization();

        app.MapPost(string.Empty,
            async (
                ProductCreateCommandRequest request,
                ISender sender,
                CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.BadRequest(res);
            })
            .Produces<Result<Guid>>();

        app.MapGet(string.Empty,
            async (
                ISender sender,
                CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new ProductGetAllQuery(), cancellationToken);
                return Results.Ok(res);
            })
            .Produces<List<ProductGetAllQueryResponse>>();

        return app;
    }
}
