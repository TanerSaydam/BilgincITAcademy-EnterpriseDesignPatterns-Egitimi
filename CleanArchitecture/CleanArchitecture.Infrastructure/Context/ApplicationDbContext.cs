using CleanArchitecture.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Context;
internal sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}