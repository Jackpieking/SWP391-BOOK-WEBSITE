﻿using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class ComicsModel : PageModel
    {
        private readonly ILogger<ComicsModel> _logger;
        private readonly EntityManagementService _entityManagementService;

        public IEnumerable<ComicModel> ComicList { get; set; }

        public ComicsModel(ILogger<ComicsModel> logger, EntityManagementService entityManagementService)
        {
            _logger = logger;
            _entityManagementService = entityManagementService;
        }

        public async Task OnGet()
        {
            ComicList = await _entityManagementService.GetAllComicAsync();
        }
    }
}