using CleanArchitecture.Domain.Products;
using Mapster;
using MediatR;

namespace CleanArchitecture.Application.Products;
public sealed record ProductCreateCommandRequest(
    string Name,
    decimal Price) : IRequest<Guid>;

internal sealed class ProductCreateCommandRequestHandler(
    IProductRepository productRepository
    ) : IRequestHandler<ProductCreateCommandRequest, Guid>
{
    public async Task<Guid> Handle(ProductCreateCommandRequest request, CancellationToken cancellationToken)
    {
        //validation
        var isNameExists = await productRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

        if (isNameExists)
        {
            //hata fırlat
        }
        //Unique

        Product product = request.Adapt<Product>();

        // await productRepository.CreateAsync(product);

        return product.Id;
    }
}