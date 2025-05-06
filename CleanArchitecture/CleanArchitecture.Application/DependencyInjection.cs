using CleanArchitecture.Application.Behaviors;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configure =>
        {
            configure.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            configure.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        // services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        return services;
    }
}
