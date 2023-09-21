using HealthChecks.UI.Client;
using RealStateWebDotNet7Api.App.Interface;
using RealStateWebDotNet7Api.App.Main;
using RealStateWebDotNet7Api.CrossApp.Common;
using RealStateWebDotNet7Api.CrossApp.Log;
using RealStateWebDotNet7Api.CrossApp.Mapper;
using RealStateWebDotNet7Api.Domain.Core;
using RealStateWebDotNet7Api.Domain.Interface;
using RealStateWebDotNet7Api.Infra.Data;
using RealStateWebDotNet7Api.Infra.Interface;
using RealStateWebDotNet7Api.Infra.Repository;
using RealStateWebDotNet7Api.Services.WebApi.Helpers;
using RealStateWebDotNet7Api.Services.WebApi.Modules.HealthCheck;
using RealStateWebDotNet7Api.Services.WebApi.Swagger;
using RealStateWebDotNet7Api.Services.WebApi.Versioning;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var myAppSettings = builder.Configuration.GetSection("Config");
builder.Services.Configure<AppSettings>(myAppSettings);

builder.Services.AddOptions();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddVersioning();
builder.Services.AddSwagger();
builder.Services.AddHealthCheck(builder.Configuration);

// Configure the HTTP request pipeline.
builder.Services.AddAutoMapper(typeof(MappingsProfile));

builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>();
builder.Services.AddScoped<IResidentApplication, ResidentApplication>();
builder.Services.AddScoped<IResidentsDomain, ResidentsDomain>();
builder.Services.AddScoped<IResidentRepository, ResidentsRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IUsersApplication, UsersApplication>();
builder.Services.AddScoped<IUsersDomain, UsersDomain>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped(typeof(IAppLoger<>), typeof(LoggerAdapter<>));


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapHealthChecks("/HealthCheck", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
}) ;
app.MapHealthChecksUI();
app.MapControllers();

app.Run();


public partial class Program
{

};