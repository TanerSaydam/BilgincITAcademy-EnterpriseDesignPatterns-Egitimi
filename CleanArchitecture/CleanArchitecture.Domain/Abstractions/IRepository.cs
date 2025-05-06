using System.Linq.Expressions;

namespace CleanArchitecture.Domain.Abstractions;

public interface IRepository<T>
{
    Task CreateAsync(T entity, CancellationToken cancellationToken = default);
    List<T> GetAll();
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
}
