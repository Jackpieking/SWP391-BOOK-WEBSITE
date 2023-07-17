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

        public IList<ReviewChapterDto> ChapterReviewDetails { get; set; }

        public async Task<IActionResult> OnGetAsync([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction Get Chapter Reviews Of A User !!");

            var reviewChapterDtos = await _service.GetAllChapterReview_OfAUser_ByUserId(userId);
            ChapterReviewDetails = new List<ReviewChapterDto>();
            ChapterReviewDetails = _mapper.Map<List<ReviewChapterDto>>(reviewChapterDtos);
            _logger.LogCritical(message: "Finished Transaction Get Chapter Reviews Of A User !!");
            return Page();
        }

        public async Task<IActionResult> OnGetDeleteChapterReview([FromRoute] Guid userId, [FromQuery] Guid chapterId)
        {
            _logger.LogCritical(message: "Start Transaction Delete Chapter Reviews Of A User !!");

            await _service.DeleteUserReviewedChapterByIdAsync(userId, chapterId);

            _logger.LogCritical(message: "Finished Transaction Delete Chapter Reviews Of A User !!");

            return RedirectToPage(pageName: "chapter-review-details", pageHandler: "OnGetAsync", routeValues: new { userId });
        }
    }
}