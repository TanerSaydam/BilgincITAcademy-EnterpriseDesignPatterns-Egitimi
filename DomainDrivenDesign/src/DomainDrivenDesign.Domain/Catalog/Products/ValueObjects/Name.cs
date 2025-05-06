namespace DomainDrivenDesign.Domain.Catalog.Products.ValueObjects;

public sealed record Name //Value objects
{
    public string Value { get; init; } = default!;
    public Name(string value)
    {
        if (value.Length <= 3)
        {
            throw new ArgumentException("Ad 3 karakterden fazla olmalıdır");
        }

        if (value.Length > 20)
        {
            throw new ArgumentException("Ürün adı 20 karakter den fazla olamaz");
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
