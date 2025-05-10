namespace CleanArchitecture.WebAPI.Endpoints;

public static class _Endpoint
{
    public static WebApplication MapMinimalEndpoint(this WebApplication app)
    {
        app.MapProducts();
        app.MapAuth();
        return app;
    }
}
