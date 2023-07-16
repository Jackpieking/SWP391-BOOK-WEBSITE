using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class comic_review_detailsModel : PageModel
    {
        private readonly EntityManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<comic_review_detailsModel> _logger;

        public comic_review_detailsModel(EntityManagementService service, IMapper mapper, ILogger<comic_review_detailsModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IList<ReviewComicDto> ComicReviewDetails { get; set; }

        public async Task<IActionResult> OnGetAsync([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction Get Comic Reviews Of A User !!");
            var reviewComicDtos = await _service.GetAllComicReview_OfAUser_ByUserId(userId);
            ComicReviewDetails = new List<ReviewComicDto>();
            ComicReviewDetails = _mapper.Map<List<ReviewComicDto>>(reviewComicDtos);
            _logger.LogCritical(message: "Finished Transaction Get Comic Reviews Of A User !!");

            return Page();
        }

        public async Task<IActionResult> OnGetDeleteComicReview([FromRoute] Guid userId, [FromQuery] Guid comicId)
        {
            _logger.LogCritical(message: "Start Transaction Delete Comic Reviews Of A User !!");

            await _service.DeleteUserReviewedComicByIdAsync(userId, comicId);

            _logger.LogCritical(message: "Finished Transaction Delete Comic Reviews Of A User !!");

            return RedirectToPage(pageName: "comic-review-details", pageHandler: "OnGetAsync", routeValues: new { userId });
        }
    }
}