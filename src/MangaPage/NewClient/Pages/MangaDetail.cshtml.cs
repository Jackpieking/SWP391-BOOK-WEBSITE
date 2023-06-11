using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NewClient.Models;
using NewClient.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class MangaDetailModel : PageModel
{
    private readonly ILogger<MangaDetailModel> _logger;
    private readonly ComicService _comicService;

    public ComicWithPublisherModel ComicWithPublisherModel { get; set; }

    public IEnumerable<ComicModel> HotComicModels { get; set; }

    public MangaDetailModel(
        ILogger<MangaDetailModel> logger,
        ComicService comicService)
    {
        _logger = logger;
        _comicService = comicService;
    }

    public async Task<IActionResult> OnGetAsync([FromRoute] Guid comicIdentifier)
    {
        try
        {
            ComicWithPublisherModel = await _comicService
                .GetComicDetailFromApiAsync(comicIdentifier);

            HotComicModels = (await _comicService
                .GetAllComicModelFromApiAsync())
                .OrderByDescending(keySelector: comicModel => comicModel.NumberOfReaderHasRead);

            return Page();
        }
        catch (TaskCanceledException TC_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {TC_2.Message}", DateTime.Now, TC_e.Message);

            return NotFound(value: "Error");
        }
        catch (HttpRequestException HR_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {HR_e.Message}", DateTime.Now, HR_e.Message);

            return NotFound(value: "Error");
        }
        catch (JsonSerializationException JS_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {JS_e.Message}", DateTime.Now, JS_e.Message);

            return NotFound(value: "Error");
        }
    }

    public IActionResult OnPost([FromForm] string reviewComic)
    {
        return RedirectToAction(actionName: nameof(OnGetAsync),
                                routeValues: ViewData["comicIdentifier"]);
    }
}
