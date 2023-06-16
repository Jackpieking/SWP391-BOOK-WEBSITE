using AutoMapper;
using BusinessLogicLayer.Services.ComicCrawlerService;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class CrawlComicController : ControllerBase
{
	private readonly IMapper _mapper;
	private readonly TruyenQQPageHandlerService _truyenQQPageHandlerService;

	public CrawlComicController(
		IMapper mapper,
		TruyenQQPageHandlerService truyenQQPageHandlerService)
	{
		_mapper = mapper;
		_truyenQQPageHandlerService = truyenQQPageHandlerService;
	}

	[HttpGet]
	public async Task<IActionResult> UpdateComicToDatabaseAsync()
	{
		await _truyenQQPageHandlerService.CrawlComicsAsync(startPage: 1, endPage: 2);

		return Ok();
	}
}
