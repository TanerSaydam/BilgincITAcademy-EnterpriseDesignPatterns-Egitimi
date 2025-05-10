using System.Threading.RateLimiting;
using CleanArchitecture.Application;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Options;
using CleanArchitecture.WebAPI;
using CleanArchitecture.WebAPI.Endpoints;
using CleanArchitecture.WebAPI.Middlewares;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Microsoft.AspNetCore.RateLimiting;
using Scalar.AspNetCore;
using Serilog;
using Serilog.Sinks.MSSqlServer;

#region Service Registration(container)
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

    options.AddFixedWindowLimiter("fixed2", options =>
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

builder.Services.AddExceptionHandler<MyExceptionHandler>().AddProblemDetails();

//builder.Services.AddScoped<MyExceptionMiddleware>(); //.net 8 den önce

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console(Serilog.Events.LogEventLevel.Information)
    .WriteTo.File("log.txt", rollingInterval: RollingInterval.Minute)
    .WriteTo
    .MSSqlServer(
            connectionString: "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerceAIDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False",
            //restrictedToMinimumLevel: LogEventLevel.Information,
            sinkOptions: new MSSqlServerSinkOptions
            {
                TableName = "LogEvents",
                AutoCreateSqlTable = true
            }
        )
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddServiceTool();

builder.Services.AddHostedService<MailBackgroundService>();
#endregion //Service Provider a kaydoluyor // GetRequiredServices => 

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

app.UseExceptionHandler();

//app.UseMiddleware<MyExceptionMiddleware>();

//app.Use(async (context, next) =>
//{
//    try
//    {
//        await next(context);
//    }
//    catch (Exception ex)
//    {

//        context.Response.StatusCode = 502;
//        await context.Response.WriteAsJsonAsync(new { Message = ex.Message });
//    }

//});

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