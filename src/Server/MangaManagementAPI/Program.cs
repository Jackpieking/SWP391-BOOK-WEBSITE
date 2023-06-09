using BusinessLogicLayer.Services.Contracts;
using BusinessLogicLayer.Services.Implementations;
using DataAccessLayer.Data;
using DataAccessLayer.Options;
using DataAccessLayer.UnitOfWorks.Contracts;
using DataAccessLayer.UnitOfWorks.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args: args);

//Configure logging
builder.Host.ConfigureLogging(configureLogging: logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

//add services to application
var services = builder.Services;

services
    .AddScoped<IUnitOfWork, UnitOfWork>()
    .AddScoped<IComicService, ComicService>()
    .ConfigureOptions<DatabaseOptionUpdates>()
    .AddCors(setupAction: cors => cors.AddDefaultPolicy(configurePolicy: policy =>
    {
        policy
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    }))
    .AddDbContextPool<MangaContext>((service, config) =>
    {
        var databaseOptions = service.GetRequiredService<IOptions<DatabaseOptions>>().Value;

        config
            .UseNpgsql(connectionString: databaseOptions.DefaultConnectionString, npgsqlOptionsAction: config =>
            {
                config
                    .MigrationsAssembly(assemblyName: Assembly.GetExecutingAssembly().FullName)
                    .EnableRetryOnFailure(maxRetryCount: databaseOptions.MaxRetryCount)
                    .CommandTimeout(commandTimeout: databaseOptions.CommandTimeOut);
            })
            .EnableDetailedErrors(detailedErrorsEnabled: databaseOptions.EnableDetailedErrors)
            .EnableServiceProviderCaching(cacheServiceProvider: databaseOptions.EnableServiceProviderCaching)
            .EnableSensitiveDataLogging(sensitiveDataLoggingEnabled: databaseOptions.EnableSensitiveDataLogging)
            .EnableThreadSafetyChecks(enableChecks: databaseOptions.EnableThreadSafetyCheck);


    })
    .AddControllers();

var app = builder.Build();

//config http/https pipleline
app
    .UseHsts()
    .UseHttpsRedirection()
    .UseCors()
    .UseRouting();

app.MapControllers();

app.Run();