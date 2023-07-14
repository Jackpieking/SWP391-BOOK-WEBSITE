using Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NewClient.Models;
using NewClient.Services;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewClient.Pages
{
    public class ComicReadingModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ChapterImageService _chapterImageService;

        public DisplayAllChapterImagesOfAChapterModel DisplayAllChapterImagesOfAChapterModel { get; set; }

        public ComicReadingModel(
            ILogger<IndexModel> logger,
            ChapterImageService chapterImageService)
        {
            _logger = logger;
            _chapterImageService = chapterImageService;
        }

        public async Task<IActionResult> OnGet([FromRoute] Guid chapterIdentifier)
        {
            try
            {
                DisplayAllChapterImagesOfAChapterModel = await _chapterImageService
                                  .GetTotalNumberOfImagesOfAChapter(chapterIdentifier: chapterIdentifier);

                DisplayAllChapterImagesOfAChapterModel.ChapterImages.ForEach(action: chapterImage
                    => chapterImage.ImageURL
                        = $"https://localhost:7174/api/Image/ComicImages/{DisplayAllChapterImagesOfAChapterModel.ComicName}?chapterNumber={DisplayAllChapterImagesOfAChapterModel.ChapterNumber}&imageURL={chapterImage.ImageURL}");

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
}
