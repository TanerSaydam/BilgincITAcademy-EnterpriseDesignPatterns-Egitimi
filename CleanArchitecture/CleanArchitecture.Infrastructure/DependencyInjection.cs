using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace CleanArchitecture.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //services.AddScoped<IProductRepository, ProductRepository>();

        services.Scan(opt => opt
        .FromAssemblies(typeof(ProductRepository).Assembly)
        .AddClasses(publicOnly: false)
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsImplementedInterfaces()
        .WithScopedLifetime()
        );

        return services;
    }
}
