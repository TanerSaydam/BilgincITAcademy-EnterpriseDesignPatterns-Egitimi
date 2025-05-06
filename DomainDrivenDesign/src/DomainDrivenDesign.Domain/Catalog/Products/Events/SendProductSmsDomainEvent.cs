using MediatR;

namespace DomainDrivenDesign.Domain.Catalog.Products.Events;

public sealed record SendProductSmsDomainEvent : INotificationHandler<ProductDomainEvent>
{
    public async Task Handle(ProductDomainEvent notification, CancellationToken cancellationToken)
    {
        //notification.Id;
        //throw new NotImplementedException();
        await Task.CompletedTask;
    }
}
