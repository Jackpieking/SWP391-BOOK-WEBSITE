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
            ComicReviewDetails = new List<ReviewComicDto>();
            ComicReviewDetails = _mapper.Map<List<ReviewComicDto>>(await _service.GetAllComicReview_OfAUser_ByUserId(userId));
            return Page();
        }

        public async Task<IActionResult> OnGetDeleteComicReview([FromRoute] Guid userId, [FromQuery] Guid comicId)
        {
            await _service.DeleteUserReviewedComicByIdAsync(userId, comicId);
            return RedirectToPage(pageName: "comic-review-details", pageHandler: "OnGetAsync", routeValues: new { userId });
        }
    }
}
