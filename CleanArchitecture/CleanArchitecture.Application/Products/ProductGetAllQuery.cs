using CleanArchitecture.Domain.Products;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Products;
public sealed record ProductGetAllQuery() : IRequest<List<ProductGetAllQueryResponse>>;

public sealed class ProductGetAllQueryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
}

internal sealed class ProductGetAllQueryHandler(
    IProductRepository productRepository) : IRequestHandler<ProductGetAllQuery, List<ProductGetAllQueryResponse>>
{
    public async Task<List<ProductGetAllQueryResponse>> Handle(ProductGetAllQuery request, CancellationToken cancellationToken)
    {
        var res = await productRepository.GetAll()
            .Select(s => new ProductGetAllQueryResponse
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToListAsync(cancellationToken);

        return res;
    }
}
