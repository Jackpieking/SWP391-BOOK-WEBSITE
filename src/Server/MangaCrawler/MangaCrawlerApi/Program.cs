using Hangfire;
using Hangfire.PostgreSql;
using MangaCrawlerApi.Data;
using MangaCrawlerApi.Mappers;
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
using System.IO;
using System.Net;
using System.Reflection;

ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var builder = WebApplication.CreateBuilder(args: args);

//Configure logging
builder.Host.ConfigureLogging(configureLogging: logging
	=> logging.AddConsole());

// Add services to the container.
var services = builder.Services;

//others
services
	.ConfigureOptions<DatabaseOptionsSetup>()
	.AddScoped<TruyenQQPageHandlerService>()
	.AddScoped<ApiCallingService>();

// Add swagger
services.AddSwaggerGen(options =>
{
	options.SwaggerDoc(name: "v1", info: new()
	{
		Version = "v1",
		Title = "Crawl Manga Api",
		Description = @"An ASP.NET Core Web API for crawling manga using hangfire as background service</br>
                        Please also open following path ""https://localhost:7229/hangfire""
                        to open the hangfire dashboard for monitoring background task",
		License = new()
		{
			Name = "License: MIT",
			Url = new(uriString: "https://opensource.org/license/mit/")
		}
	});

	var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
	options.IncludeXmlComments(filePath: Path.Combine(path1: AppContext.BaseDirectory, path2: xmlFilename));
});


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

//automapper
services.AddAutoMapper(profileAssemblyMarkerTypes: typeof(ModelAndDtoProfile));

//controller
services
	.AddControllers(configure: option
		=> option.SuppressAsyncSuffixInActionNames = true);

//Httpclient
services
	.AddHttpClient(name: "truyenqqne", configureClient: configure =>
	{
		configure.DefaultRequestHeaders.Add(name: "Referer", value: "https://truyenqqne.com/");
		configure.BaseAddress = new(uriString: "https://truyenqqne.com/");
		configure.Timeout = TimeSpan.FromSeconds(value: 30);
	});

services
	.AddHttpClient(name: "MangaApi", configureClient: configure =>
	{
		configure.BaseAddress = new(uriString: "https://localhost:7174/");
		//configure.Timeout = TimeSpan.FromSeconds(value: 30);
	});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
	app
		.UseSwagger()
		.UseSwaggerUI();
}

app
	.UseHsts()
	.UseHttpsRedirection()
	.UseRouting()
	.UseCors();

app.MapControllers();
app.MapHangfireDashboard();

app.Run();
