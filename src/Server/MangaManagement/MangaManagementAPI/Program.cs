﻿using BusinessLogicLayer.Services;
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
using System.Reflection;

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
    .ConfigureOptions<DatabaseOptionUpdates>();

//mapper profile
services
    .AddAutoMapper(
                   typeof(UserInfoEntityAndUserInfoModelProfile),
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
                   typeof(ChapterImageToGetAllChapterImageOfAChapterDtoProfile));

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

//controller
services
    .AddControllers(configure: option => option.SuppressAsyncSuffixInActionNames = true);

var app = builder.Build();

//config http/https pipleline
app
    .UseHsts()
    .UseHttpsRedirection()
    .UseRouting()
    .UseCors();

app.MapControllers();

app.Run();