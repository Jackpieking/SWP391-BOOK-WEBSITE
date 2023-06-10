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

    public IEnumerable<ComicModel> AllComicModels { get; set; }

    public IEnumerable<ComicModel> HotComicModels { get; set; }

    public IEnumerable<ComicModel> RecentlyAddedComicModels { get; set; }

    public IEnumerable<ComicModel> ComicHasTheLastestComicReviewModels { get; set; }

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
            AllComicModels = await _comicService.GetAllComicModelFromApiAsync();
            HotComicModels = AllComicModels
                .OrderByDescending(keySelector: comicModel => comicModel.NumberOfReaderHasRead)
                .ThenByDescending(keySelector: comicModel => comicModel.ReviewCount);
            RecentlyAddedComicModels = AllComicModels.OrderByDescending(keySelector: comicModel => comicModel.ComicPublishDate);
            ComicHasTheLastestComicReviewModels = AllComicModels.OrderByDescending(keySelector: comicModel => comicModel.LastestComicReviewDate);

            return Page();
        }
        catch (TaskCanceledException TC_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {TC_2.Message}", DateTime.Now, TC_e.Message);

            return NotFound("Error");
        }
        catch (HttpRequestException HR_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {HR_e.Message}", DateTime.Now, HR_e.Message);

            return NotFound("Error");
        }
        catch (JsonSerializationException JS_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {JS_e.Message}", DateTime.Now, JS_e.Message);

            return NotFound("Error");
        }
    }
}