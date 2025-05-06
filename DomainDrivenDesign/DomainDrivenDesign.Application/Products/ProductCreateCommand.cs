using DomainDrivenDesign.Domain.Catalog.Products;
using DomainDrivenDesign.Domain.Catalog.Products.ValueObjects;
using DomainDrivenDesign.Domain.Products.Events;
using MediatR;

namespace DomainDrivenDesign.Application.Products;
public sealed record ProductCreateCommand(
    string Name,
    string Description,
    int Stock,
    decimal Price,
    string PriceType) : IRequest;

//validation

internal sealed class ProductCreateCommandHandler(
    IMediator mediator) : IRequestHandler<ProductCreateCommand>
{
    public async Task Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        Name name = new(request.Name);
        Description description = new(request.Description);
        Stock stock = new(request.Stock);
        Currency currency = new(request.Price, request.PriceType);

        Product product = Product.Create(name, description, stock, currency);
        product.SetName(new("Taner Saydam"));

        //db kayıt

        await mediator.Publish(new ProductDomainEvent(product.Id));

        // email gönderme
        // sms gönderme
    }
}
