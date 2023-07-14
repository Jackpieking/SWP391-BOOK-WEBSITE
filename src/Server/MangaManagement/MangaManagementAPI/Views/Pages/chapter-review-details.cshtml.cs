using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class chapter_review_detailsModel : PageModel
    {
        private readonly EntityManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<chapter_review_detailsModel> _logger;

        public chapter_review_detailsModel(EntityManagementService service, IMapper mapper, ILogger<chapter_review_detailsModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IList<ReviewChapterDto> ChapterReviewDetail { get; set; }

        public async Task<IActionResult> OnGetAsync([FromRoute] Guid userId)
        {
            ChapterReviewDetail = new List<ReviewChapterDto>();

            ChapterReviewDetail = _mapper.Map<List<ReviewChapterDto>>(await _service.GetAllChapterReview_OfAUser_ByUserId(userId));
            return Page();
        }

        public async Task<IActionResult> OnGetDeleteChapterReview([FromRoute] Guid userId, [FromQuery] Guid chapterId)
        {
            await _service.DeleteUserReviewedChapterByIdAsync(userId, chapterId);
            return RedirectToPage(pageName: "chapter-review-details", pageHandler: "OnGetAsync", routeValues: new { userId });
        }
    }
}
