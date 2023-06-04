using MangaManagementAPI.Data;
using MangaManagementAPI.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args: args);

//add services to application
var services = builder.Services;

services
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
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler(errorHandlingPath: "/Error");
	app.UseHsts();
}

app
	.UseHttpsRedirection()
	.UseCors()
	.UseRouting();

app.MapControllers();

app.Run();