using CleanArchitecture.Application.Products;
using MediatR;

namespace CleanArchitecture.WebAPI.Endpoints;

public static class ProductModule
{
    public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder builder)
    {
        var app = builder.MapGroup("products").RequireAuthorization().RequireRateLimiting("fixed");

        app.MapPost(string.Empty,
            async (
                ProductCreateCommandRequest request,
                ISender sender,
                CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return Results.Ok(res);
            })
            .Produces<Guid>();

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
