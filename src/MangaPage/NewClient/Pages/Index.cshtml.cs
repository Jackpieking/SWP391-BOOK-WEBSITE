using Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NewClient.Models;
using NewClient.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class IndexModel : PageModel
{
	private readonly ILogger<IndexModel> _logger;
	private readonly ComicService _comicService;
	private readonly UserService _userService;

	public IEnumerable<DisplayAllComicModel> AllComicModels { get; set; }

	public IEnumerable<DisplayAllComicModel> AllHotComicModels { get; set; }

	public IEnumerable<DisplayAllComicModel> AllRecentlyAddedComicModels { get; set; }

	public IEnumerable<DisplayAllComicModel> AllComicHasTheLastestComicReviewModels { get; set; }

	public IndexModel(
		ILogger<IndexModel> logger,
		ComicService comicService,
		UserService userService)
	{

		_logger = logger;
		_comicService = comicService;
		_userService = userService;
	}

	public async Task<IActionResult> OnGet()
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
}