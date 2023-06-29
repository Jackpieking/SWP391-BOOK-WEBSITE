using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.ComicCrawlerService;
using DataAccessLayer.Data;
using DataAccessLayer.Options;
using DataAccessLayer.UnitOfWorks.Contracts;
using DataAccessLayer.UnitOfWorks.Implementation;
using Helper.ObjectMappers.ModelToEntity;
using Mapper.ModelAndDto;
using Mapper.ModelAndEntity;
using Mapper.ModelToEntity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Reflection;

ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
Console.OutputEncoding = System.Text.Encoding.UTF8;

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
    .ConfigureOptions<DatabaseOptionUpdates>();

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
    });

//Httpclient
services
    .AddHttpClient(name: "truyenqqne", configureClient: configure =>
    {
        configure.DefaultRequestHeaders.Add(name: "Referer", value: "https://truyenqqne.com/");
        configure.BaseAddress = new(uriString: "https://truyenqqne.com/");
        configure.Timeout = TimeSpan.FromSeconds(value: 30);
    });

//controller
services
    .AddControllers(configure: option => option.SuppressAsyncSuffixInActionNames = true);

//RazerPage
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
    .UseCors();

app.MapControllers();

app.MapRazorPages();

app.Run();