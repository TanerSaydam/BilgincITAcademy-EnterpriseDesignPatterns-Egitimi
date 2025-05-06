using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Catalog.Products.ValueObjects;

namespace DomainDrivenDesign.Domain.Catalog.Products;
public sealed class Product : Entity<int>
{
    private Product(int id, Name name, Description description, Stock stock, Currency currency) : base(id)
    {
        Name = name;
        Description = description;
        Stock = stock;
        Price = currency;
    }

    public Name Name { get; private set; } = default!; //string,int, dec => ilkel tipler
    public Description Description { get; private set; } = default!;
    public Stock Stock { get; private set; } = default!;
    public Currency Price { get; private set; }


    public static Product Create(Name name, Description description, Stock stock, Currency currency)
    {
        Product product = new(0, name, description, stock, currency);
        return product;
    }

    public void SetName(Name name)
    {
        //Kural
        Name = name;
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
