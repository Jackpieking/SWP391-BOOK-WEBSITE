using AutoMapper;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using DTO.Incoming;

namespace MangaManagementAPI.Views.Pages
{
    public class user_comic_like_detailsModel : PageModel
    {
        private readonly EntityManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<user_comic_like_detailsModel> _logger;

        public user_comic_like_detailsModel(EntityManagementService service, IMapper mapper, ILogger<user_comic_like_detailsModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IList<ComicLikeDto> ComicLikeDetails { get; set; }
        public async Task<IActionResult> OnGetAsync([FromRoute] Guid userId)
        {
            ComicLikeDetails = new List<ComicLikeDto>();
            ComicLikeDetails = _mapper.Map<List<ComicLikeDto>>(await _service.GetComicLikesOfAUserByUserId(userId));
            return Page();
        }

        public async Task<IActionResult> OnGetDeleteComicLike([FromRoute] Guid userId, [FromQuery] Guid comicId)
        {
            await _service.DeleteUserReviewedComicByIdAsync(userId, comicId);
            return RedirectToPage(pageName: "comic-review-details", pageHandler: "OnGetAsync", routeValues: new { userId });
        }
    }
}
