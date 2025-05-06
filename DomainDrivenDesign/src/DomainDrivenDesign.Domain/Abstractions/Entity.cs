namespace DomainDrivenDesign.Domain.Abstractions;
public abstract class Entity<T> : EntityId<T>, IEquatable<Entity<T>>
{
    protected Entity(T id) : base(id)
    {
        Id = id;
    }
    public T Id { get; set; } = default!;

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is not Entity entiy)
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return entiy.Id == Id;
    }

    public bool Equals(Entity<T>? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other is not Entity entiy)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return entiy.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}


public class EntityId<T>
{
    public EntityId(T value)
    {
        Value = value;
    }
    public T Value { get; init; }
}