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
    public class user_comic_reviewsModel : PageModel
    {
        private readonly EntityManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<user_comic_reviewsModel> _logger;

        public user_comic_reviewsModel(EntityManagementService service, IMapper mapper, ILogger<user_comic_reviewsModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IDictionary<Guid, IList<ReviewComicDto>> ReviewComic { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var reviewComicModels = await _service.GetAllComicReviewAsync();

            ReviewComic = new Dictionary<Guid, IList<ReviewComicDto>>();

            foreach (var reivewComicModel in reviewComicModels)
            {
                ReviewComic.Add(reivewComicModel.Key, _mapper.Map<IList<ReviewComicDto>>(reivewComicModel.Value));
                for (int i = 0; i < reivewComicModel.Value.Count; i++)
                {
                    var review = ReviewComic[reivewComicModel.Key][i];
                    var anotherReview = reivewComicModel.Value[i];
                    review.ComicName = anotherReview.ComicModel.ComicName;
                    review.ComicStatus = anotherReview.ComicModel.ComicStatus;
                    review.Username = anotherReview.UserModel.Username;
                }
            }
            return Page();
        }
    }
}
