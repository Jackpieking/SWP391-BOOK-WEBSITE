using Helper;
using Microsoft.AspNetCore.Http;
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

    public DisplayComicDetailModel DisplayComicDetailModel { get; set; }

    public IEnumerable<DisplayAllComicModel> AllRecentlyAddedComicModels { get; set; }

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
            DisplayComicDetailModel = await _comicService
                .GetComicDetailFromApiAsync(comicIdentifier: comicIdentifier);

            DisplayComicDetailModel.ComicAvatar
                = $"https://localhost:7174/api/Image/ComicAvatar/{DisplayComicDetailModel.ComicAvatar}";

            AllRecentlyAddedComicModels = (await _comicService
                .GetAllComicFromApiAsync())
                .OrderByDescending(keySelector: comicModel => comicModel.ComicPublishedDate);

            AllRecentlyAddedComicModels.ForEach(action: comicModel =>
                comicModel.ComicAvatar
                    = $"https://localhost:7174/api/Image/ComicAvatar/{comicModel.ComicAvatar}");


            return Page();
        }
        catch (TaskCanceledException TC_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {TC_2.Message}", DateTime.Now, TC_e.Message);

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
        catch (HttpRequestException HR_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {HR_e.Message}", DateTime.Now, HR_e.Message);

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
        catch (JsonSerializationException JS_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {JS_e.Message}", DateTime.Now, JS_e.Message);

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }

    public IActionResult OnPost([FromForm] string reviewComic)
    {
        return RedirectToAction(
            actionName: nameof(OnGetAsync),
            routeValues: ViewData["comicIdentifier"]);
    }
}
