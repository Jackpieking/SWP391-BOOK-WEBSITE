using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.ComicCrawlerService;
using DataAccessLayer.Data;
using DataAccessLayer.Options;
using DataAccessLayer.UnitOfWorks.Contracts;
using DataAccessLayer.UnitOfWorks.Implementation;
using Helper.ObjectMappers.ModelToEntity;
using MangaManagementAPI.Options;
using Mapper.ModelAndDto;
using Mapper.ModelAndEntity;
using Mapper.ModelToEntity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Net;
using System.Reflection;
using System.Text;

ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
Console.OutputEncoding = Encoding.UTF8;

var builder = WebApplication.CreateBuilder(args: args);

//Configure logging
builder.Host.ConfigureLogging(configureLogging: logging
	=> logging.AddConsole());

//add services to application
var services = builder.Services;

//others
services
	.AddScoped<IUnitOfWork, UnitOfWork>()
	.AddScoped<EntityManagementService>()
	.AddScoped<UserManagementService>()
	.AddScoped<PublisherManagementService>()
	.AddScoped<TruyenQQPageHandlerService>()
	.AddScoped<ApiCallingService>()
	.AddScoped<ComicManagementService>()
	.ConfigureOptions<DatabaseOptionUpdates>()
	.ConfigureOptions<JwtConfigUdate>();

//mapper profile
services
	.AddAutoMapper(
				   typeof(UserInfoEntityAndUserInfoModelProfile),
				   typeof(ComicModelToPublisherComicOutDto),
				   typeof(TransactionHistoryEntityAndTransactionHistoryModelProfile),
				   typeof(ReviewComicEntityAndReviewComicModelProfile),
				   typeof(ReviewChapterEntityAndReviewChapterModelProfile),
				   typeof(ReadingHistoryEntityAndReadingHistoryModelProfile),
				   typeof(PublisherEntityAndPublisherModelProfile),
				   typeof(ComicSavingEntityAndComicSavingModelProfile),
				   typeof(ComicEntityAndComicModelProfile),
				   typeof(ComicCategoryEntityAndComicCategoryModelProfile),
				   typeof(ChapterImageEntityAndChapterImageModelProfile),
				   typeof(ChapterEntityAndChapterModelProfile),
				   typeof(CategoryEntityAndCategoryModelProfile),
				   typeof(BuyingHistoryEntityAndBuyingHistoryModelProfile),
				   typeof(ComicLikeEntityAndComicLikeModelProfile),
				   typeof(ComicModelToGetAllComicDtoProfile),
				   typeof(ComicModelToGetComicDetailDtoProfile),
				   typeof(PublisherModelToGetPublisherDto),
				   typeof(ChapterImageToGetAllChapterImageOfAChapterDtoProfile),
				   typeof(UpdateCrawlDataToDatabaseAction_In_DtoToEntityProfile));

//cors
services
	.AddCors(setupAction: cors => cors.AddDefaultPolicy(configurePolicy: policy =>
	{
		policy
			.AllowAnyHeader()
			.AllowAnyMethod()
			.AllowAnyOrigin();
	}));

//dbcontext
services
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
	.AddDbContextPool<UserIdentityContext>((service, config) =>
	{
		var databaseOptions = service.GetRequiredService<IOptions<DatabaseOptions>>().Value;

		config
			.UseNpgsql(connectionString: builder.Configuration.GetConnectionString("UserIdentityDbConnectionString"), npgsqlOptionsAction: config =>
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
	});

//asp net core identity
services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
	// Thiết lập về Password
	options.Password.RequireDigit = true;
	options.Password.RequireLowercase = false;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireUppercase = true;
	options.Password.RequiredLength = 3;
	options.Password.RequiredUniqueChars = 0;

	// Cấu hình Lockout - khóa user
	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(value: 1);
	options.Lockout.MaxFailedAccessAttempts = 5;
	options.Lockout.AllowedForNewUsers = true;

	// Cấu hình về User.
	options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
	options.User.RequireUniqueEmail = true;

	// Cấu hình đăng nhập.
	options.SignIn.RequireConfirmedEmail = true;
	options.SignIn.RequireConfirmedPhoneNumber = false;
})
.AddEntityFrameworkStores<UserIdentityContext>()
.AddDefaultTokenProviders();

//jwt configuration
services
	.AddAuthentication(options =>
	{
		options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
		options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
		options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	})
	.AddJwtBearer(jwt =>
	{
		jwt.SaveToken = true;

		jwt.TokenValidationParameters = new()
		{
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			RequireExpirationTime = false,
			ValidIssuer = builder.Configuration.GetRequiredSection("JwtConfig:Issuer").Value,
			ValidAudience = builder.Configuration.GetRequiredSection("JwtConfig:Audience").Value,
			IssuerSigningKey = new SymmetricSecurityKey(
				Encoding.UTF8.GetBytes(
					builder.Configuration.GetRequiredSection("JwtConfig:PrivateKey").Value
					)
				)
		};
	});

//Httpclient
services
	.AddHttpClient(name: "truyenqqne", configureClient: configure =>
	{
		configure.DefaultRequestHeaders.Add(name: "Referer", value: "https://truyenqqne.com/");
		configure.BaseAddress = new(uriString: "https://truyenqqne.com/");
		configure.Timeout = TimeSpan.FromSeconds(value: 30);
	});

//RazorPage
services
	.AddRazorPages()
	.AddRazorPagesOptions(options =>
	{
		options.RootDirectory = "/Views";
	});

var app = builder.Build();

//config http/https pipleline
app
	.UseHsts()
	.UseHttpsRedirection()
	.UseStaticFiles()
	.UseRouting()
	.UseCors()
	.UseAuthentication()
	.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller}/{action=Index}/{id?}"
);

app.MapRazorPages();

app.Run();