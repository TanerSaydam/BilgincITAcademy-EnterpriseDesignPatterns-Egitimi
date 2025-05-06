using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Shared;

namespace CleanArchitecture.Domain.Products;
public sealed class Product : Entity
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public CurrencyEnum Currency { get; set; } = CurrencyEnum.TL;
}
