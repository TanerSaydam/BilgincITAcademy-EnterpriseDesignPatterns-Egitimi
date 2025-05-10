using System.Linq.Expressions;
using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories;
internal class Repository<T>(
    ApplicationDbContext dbContext) : IRepository<T>
    where T : class
{
    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<T>().AnyAsync(predicate, cancellationToken);
    }

    public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        await dbContext.AddAsync(entity, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public IQueryable<T> GetAll()
    {
        return dbContext.Set<T>().AsQueryable();
    }
}
