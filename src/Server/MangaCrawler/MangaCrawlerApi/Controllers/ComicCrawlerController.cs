using Hangfire;
using MangaCrawlerApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;

namespace MangaCrawlerApi.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicCrawlerController : ControllerBase
{
    private readonly TruyenQQPageHandlerService _service;

    public ComicCrawlerController(TruyenQQPageHandlerService service)
    {
        _service = service;
    }

    /// <summary>
    /// Start a crawling manga job
    /// </summary>
    ///<response code="200">Start a background task fro crawling manga</response>
    [HttpGet]
    public IActionResult StartCrawlJob(CancellationToken cancellationToken)
    {
        BackgroundJob.Enqueue(methodCall: () => AsyncMethodWrapper(cancellationToken));

        //RecurringJob.AddOrUpdate(
        //    recurringJobId: "crawl-truyenqqne",
        //    methodCall: () => AsyncMethodWrapper(cancellationToken),
        //    cronExpression: Cron.Hourly());

        return Ok();
    }

    public void AsyncMethodWrapper(CancellationToken cancellationToken)
    {
        Task
            .Run(
                function: async () => await _service.ParsePageAndGetAllComicOfPage(cancellationToken: cancellationToken),
                cancellationToken: cancellationToken)
            .Wait(cancellationToken);
    }
}
