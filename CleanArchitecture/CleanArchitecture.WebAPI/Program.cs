using System.Threading.RateLimiting;
using CleanArchitecture.Application;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Options;
using CleanArchitecture.WebAPI.Endpoints;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Microsoft.AspNetCore.RateLimiting;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("keycloak.json");

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", options =>
    {
        options.QueueLimit = 100;
        options.PermitLimit = 100;
        options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        options.Window = TimeSpan.FromSeconds(1);
    });
});

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddHttpClient();

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});

builder.Services.AddCors();

builder.Services.Configure<KeycloakOptions>(builder.Configuration.GetSection("KeyclockOptions"));

builder.Services.AddKeycloakWebApiAuthentication(builder.Configuration);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("getall", builder =>
    {
        builder.RequireResourceRoles("read");
    });
}).AddKeycloakAuthorization(builder.Configuration);

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app.UseCors(x => x
    .AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .SetPreflightMaxAge(TimeSpan.FromMinutes(10))
);

app.UseResponseCompression();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers().RequireRateLimiting("fixed");

app.MapMinimalEndpoint();

app.MapGet("get-access-token",
    async (IKeycloakService keycloakService, CancellationToken cancellationToken) =>
    {
        var res = await keycloakService.GetAccessTokenAsync(cancellationToken);
        return new { Token = res };
    })
    .Produces<object>();

app.MapGet("/test", () =>
{
    return Results.Ok(new { Message = "Is working..." });
}).RequireAuthorization();

app.Run();