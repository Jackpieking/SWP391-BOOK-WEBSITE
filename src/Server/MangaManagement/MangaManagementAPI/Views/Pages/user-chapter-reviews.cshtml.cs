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
    public class user_chapter_reviewsModel : PageModel
    {
        private readonly EntityManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<user_chapter_reviewsModel> _logger;

        public user_chapter_reviewsModel(EntityManagementService service, IMapper mapper, ILogger<user_chapter_reviewsModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IDictionary<Guid, IList<ReviewChapterDto>> ReviewChapter { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            _logger.LogCritical(message: "Start Transaction Get Chapter Reviews !!");
            var reviewChapterModels = await _service.GetAllChapterReviewAsync();
            ReviewChapter = new Dictionary<Guid, IList<ReviewChapterDto>>();
            foreach (var reviewChapterModel in reviewChapterModels)
            {
                ReviewChapter.Add(reviewChapterModel.Key, _mapper.Map<IList<ReviewChapterDto>>(reviewChapterModel.Value));
                for (int i = 0; i < reviewChapterModel.Value.Count; i++)
                {
                    var review = ReviewChapter[reviewChapterModel.Key][i];
                    var anotherReview = reviewChapterModel.Value[i];
                    review.ComicName = anotherReview.ChapterModel.ComicModel.ComicName;
                    review.Username = anotherReview.UserModel.Username;
                    review.ChapterNumber = anotherReview.ChapterModel.ChapterNumber;
                }
            }
            _logger.LogCritical(message: "Finished Transaction Get Chapter Reviews !!");
            return Page();
        }
    }
}
