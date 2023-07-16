using AutoMapper;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class user_comic_likeModel : PageModel
    {
        private readonly UserManagementService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<user_comic_likeModel> _logger;

        public user_comic_likeModel(UserManagementService service, IMapper mapper, ILogger<user_comic_likeModel> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<UserModel> userModels { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            userModels = _service.GetAllUserHaveLikeAsync().Result;
            return Page();
        }
    }
}
