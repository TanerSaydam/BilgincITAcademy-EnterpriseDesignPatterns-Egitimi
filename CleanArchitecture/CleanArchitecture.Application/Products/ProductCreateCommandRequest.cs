using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Products;
using Mapster;
using MediatR;

namespace CleanArchitecture.Application.Products;
public sealed record ProductCreateCommandRequest(
    string Name,
    decimal Price) : IRequest<Result<Guid>>;

internal sealed class ProductCreateCommandRequestHandler(
    IProductRepository productRepository
    ) : IRequestHandler<ProductCreateCommandRequest, Result<Guid>>
{
    public async Task<Result<Guid>> Handle(ProductCreateCommandRequest request, CancellationToken cancellationToken)
    {
        //validation
        var isNameExists = await productRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);


        if (isNameExists)
        {
            return Result<Guid>.Failure("Ürün adı daha önce oluşturulmuş");
        }
        //Unique

        Product product = request.Adapt<Product>();

        await productRepository.CreateAsync(product);

        return product.Id; //15:05 de görüşelim
    }
}