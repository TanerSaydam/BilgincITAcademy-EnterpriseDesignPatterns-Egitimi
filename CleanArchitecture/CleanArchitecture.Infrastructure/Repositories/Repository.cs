using System.Linq.Expressions;
using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Infrastructure.Repositories;
public class Repository<T> : IRepository<T>
{
    public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(true);
        //throw new NotImplementedException();
    }

    public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;
        //throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
        return new();
        //throw new NotImplementedException();
    }
}
