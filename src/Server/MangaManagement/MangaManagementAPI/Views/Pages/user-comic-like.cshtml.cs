using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class user_comic_likeModel : PageModel
    {
        private readonly EntityManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<user_comic_likeModel> _logger;

        public user_comic_likeModel(EntityManagementService service, IMapper mapper, ILogger<user_comic_likeModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IDictionary<Guid, IList<ComicLikeDto>> ComicLike { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var comicLikeModels = await _service.GetAllComicLikeAsync();
            ComicLike = new Dictionary<Guid, IList<ComicLikeDto>>();

            foreach (var comicLikeModel in comicLikeModels)
            {
                ComicLike.Add(comicLikeModel.Key, (IList<ComicLikeDto>)_mapper.Map<IList<ComicLikeDto>>(comicLikeModel.Value));
                for (int i = 0; i < comicLikeModels.Values.Count; i++)
                {
                    var comicLike = ComicLike[comicLikeModel.Key][i];
                    var anotherComicLike = comicLikeModel.Value[i];
                    comicLike.ComicName = anotherComicLike.ComicModel.ComicName;
                    comicLike.Username = anotherComicLike.UserModel.Username;
                }
            }
            return Page();
        }
    }
}
