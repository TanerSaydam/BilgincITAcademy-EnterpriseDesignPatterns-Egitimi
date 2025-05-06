namespace DomainDrivenDesign.Domain.Catalog.Products.ValueObjects;

public sealed record Description //Value objects
{
    public string Value { get; init; } = default!;
    public Description(string value)
    {
        if (value.Length < 20)
        {
            throw new ArgumentException("Ürün açıklaması 20 karakter den az olamaz");
        }

        Value = value;
    }
}

//class Test
//{
//    public Test()
//    {
//        Guid id = Guid.NewGuid();
//        Product product1 = new() { Id = id, Name = "Salatalık" };
//        Product product2 = new() { Id = id, Name = "Domates" };

//        var result = product1.Equals(product2); //=> true;
//    }
//}
