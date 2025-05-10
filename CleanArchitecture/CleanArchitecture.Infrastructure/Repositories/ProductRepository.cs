using CleanArchitecture.Domain.Products;
using CleanArchitecture.Infrastructure.Context;

namespace CleanArchitecture.Infrastructure.Repositories;
internal class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}