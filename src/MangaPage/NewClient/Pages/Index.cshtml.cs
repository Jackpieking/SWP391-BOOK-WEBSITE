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

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ComicService _comicService;

    public IEnumerable<DisplayAllComicModel> AllComicModels { get; set; }

    public IEnumerable<DisplayAllComicModel> AllHotComicModels { get; set; }

    public IEnumerable<DisplayAllComicModel> AllRecentlyAddedComicModels { get; set; }

    public IEnumerable<DisplayAllComicModel> AllComicHasTheLastestComicReviewModels { get; set; }

    public IndexModel(
        ILogger<IndexModel> logger,
        ComicService comicService)
    {

        _logger = logger;
        _comicService = comicService;
    }

    public async Task<IActionResult> OnGet()
    {
        try
        {
            AllComicModels = await _comicService
                .GetAllComicFromApiAsync();

            AllComicModels.ForEach(action: comicModel
                => comicModel.ComicAvatar
                    = $"https://localhost:7174/api/Image/ComicAvatar/{comicModel.ComicAvatar}");

            AllHotComicModels = AllComicModels
                .OrderByDescending(keySelector: comicModel => comicModel.ReadersCounts)
                .ThenByDescending(keySelector: comicModel => comicModel.ReviewCounts);

            AllRecentlyAddedComicModels = AllComicModels
                .OrderByDescending(keySelector: comicModel => comicModel.ComicPublishedDate);

            AllComicHasTheLastestComicReviewModels = AllComicModels
                .OrderByDescending(keySelector: comicModel => comicModel.LastestComicReviewDate);

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
}