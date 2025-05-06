using MediatR;

namespace DomainDrivenDesign.Domain.Catalog.Products.Events;
public sealed record ProductDomainEvent(int Id) : INotification;
