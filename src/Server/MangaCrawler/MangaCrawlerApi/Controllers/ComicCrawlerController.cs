using MangaCrawlerApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
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
	public async Task<IActionResult> TriggerCrawlJobAsync()
	{
		await _service.EntryPointAsync();

		//BackgroundJob.Enqueue(methodCall: () => _service.EntryPoint());

		//RecurringJob.AddOrUpdate(
		//    recurringJobId: "crawl-truyenqqne",
		//    methodCall: () => AsyncMethodWrapper(cancellationToken),
		//    cronExpression: Cron.Hourly());

		return Ok();
	}
}
