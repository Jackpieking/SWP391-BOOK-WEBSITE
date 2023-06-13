using Hangfire;
using Hangfire.PostgreSql;
using MangaCrawlerApi.Data;
using MangaCrawlerApi.Options;
using MangaCrawlerApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var builder = WebApplication.CreateBuilder(args: args);

//Configure logging
builder.Host.ConfigureLogging(configureLogging: logging
    => logging.AddConsole());

// Add services to the container.
var services = builder.Services;

services
    .ConfigureOptions<DatabaseOptionsSetup>()
    .AddScoped<TruyenQQPageHandlerService>();

//hangfire services
services
    .AddHangfire(configuration: configuration =>
    {
        var connectionString = builder
            .Configuration
            .GetConnectionString(name: "DefaultConnectionString");

        configuration
                .SetDataCompatibilityLevel(compatibilityLevel: CompatibilityLevel.Version_180)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UsePostgreSqlStorage(connectionString: connectionString);
    });

//hangfire server
services.AddHangfireServer();

//dbcontext
services
    .AddDbContextPool<HangFireContext>(optionsAction: (service, config) =>
    {
        var databaseOptions = service.GetRequiredService<IOptions<DatabaseOptions>>().Value;

        config
            .UseNpgsql(
                connectionString: databaseOptions.DefaultConnectionString,
                npgsqlOptionsAction: config =>
                {
                    config
                        .EnableRetryOnFailure(maxRetryCount: databaseOptions.MaxRetryCount)
                        .CommandTimeout(commandTimeout: databaseOptions.CommandTimeOut);
                })
            .EnableSensitiveDataLogging(sensitiveDataLoggingEnabled: databaseOptions.EnableSensitiveDataLogging)
            .EnableDetailedErrors(detailedErrorsEnabled: databaseOptions.EnableDetailedErrors)
            .EnableServiceProviderCaching(cacheServiceProvider: databaseOptions.EnableServiceProviderCaching)
            .EnableThreadSafetyChecks(enableChecks: databaseOptions.EnableThreadSafetyCheck);



    });

//cors
services
    .AddCors(cors => cors.AddDefaultPolicy(configurePolicy: policy =>
    {
        policy
            .AllowAnyMethod()
            .AllowAnyOrigin()
            .AllowAnyHeader();
    }));

//controller
services
    .AddControllers(configure: option
        => option.SuppressAsyncSuffixInActionNames = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app
    .UseHsts()
    .UseHttpsRedirection()
    .UseRouting()
    .UseCors();

app.MapControllers();
app.MapHangfireDashboard();

app.Run();
