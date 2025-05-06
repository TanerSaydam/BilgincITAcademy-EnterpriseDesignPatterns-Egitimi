namespace CleanArchitecture.Domain.Abstractions;
public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; }
    public Guid CreatedById { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public Guid? UpdatedById { get; set; }
    public DateTimeOffset? UpdatedOn { get; set; }
    #region Soft Delete
    public bool IsDeleted { get; set; } //false 
    public Guid? DeletedById { get; set; }
    public DateTimeOffset? DeletedOn { get; set; }
    #endregion
}