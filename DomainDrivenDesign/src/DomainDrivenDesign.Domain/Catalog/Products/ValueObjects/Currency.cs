namespace DomainDrivenDesign.Domain.Catalog.Products.ValueObjects;

public sealed record Currency(
    decimal Value,
    string Type);

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