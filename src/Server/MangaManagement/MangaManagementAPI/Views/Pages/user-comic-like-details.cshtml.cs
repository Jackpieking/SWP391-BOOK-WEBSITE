using AutoMapper;
using BusinessLogicLayer.Services;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class user_comic_like_detailsModel : PageModel
    {
        private readonly ComicManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<user_comic_like_detailsModel> _logger;

        public user_comic_like_detailsModel(ComicManagementService service, IMapper mapper, ILogger<user_comic_like_detailsModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<ComicLikeModel> ComicLikeDetails { get; set; }
        public async Task<IActionResult> OnGetAsync([FromRoute] Guid userId)
        {
            //ComicLikeDetails = await _service.GetComicLikesAndComicByUserIdAsync(userId);
            return Page();
        }
    }
}
