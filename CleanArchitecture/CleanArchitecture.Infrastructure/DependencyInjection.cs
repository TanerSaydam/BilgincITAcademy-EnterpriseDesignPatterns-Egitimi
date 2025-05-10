using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace CleanArchitecture.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddScoped<IProductRepository, ProductRepository>();

        services.Scan(opt => opt
        .FromAssemblies(typeof(ProductRepository).Assembly)
        .AddClasses(publicOnly: false)
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsImplementedInterfaces()
        .WithScopedLifetime()
        );

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            string connectionString = configuration.GetConnectionString("MemoryDb")!;
            options.UseInMemoryDatabase(connectionString);
        });

        return services;
    }
}
