using DomainDrivenDesign.Domain.Abstractions;

namespace DomainDrivenDesign.Domain.Orders;
public sealed class Order : Entity<int>, IAgregateRoot
{
    public Order(int id) : base(id)
    {
    }
    public DateTimeOffset Date { get; set; }
    public ICollection<OrderItem> Items { get; set; }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }
    public void RemoveItem(int itemId)
    {
        var item = Items.First(p => p.Id == itemId);
        Items.Remove(item);
    }
}

public sealed class OrderItem : Entity<int>, IAgregate
{
    public OrderItem(int id) : base(id)
    {
    }

    public Entity<int> OrderId { get; set; }
    public Entity<int> ProductId { get; set; }
    public int Quantity { get; set; }
}

public interface IAgregate
{

}

public interface IAgregateRoot
{

}