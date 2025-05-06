using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.WebAPI.Endpoints;
using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure();
builder.Services.AddApplication();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app.MapControllers();

app.MapMinimalEndpoint();

app.Run();


//static class Extensions
//{
//    public static string ChangeMyName(this string str)
//    {
//        return "Taner Saydam";
//    }
//}