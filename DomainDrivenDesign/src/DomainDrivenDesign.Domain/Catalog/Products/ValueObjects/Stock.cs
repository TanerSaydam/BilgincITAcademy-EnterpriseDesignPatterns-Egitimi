namespace DomainDrivenDesign.Domain.Catalog.Products.ValueObjects;

public sealed record Stock //Value objects
{
    public int Value { get; init; }
    public Stock(int value)
    {
        if (value < 1)
        {
            throw new ArgumentException("Ürün stock adedi 1 den küçük olamaz");
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
