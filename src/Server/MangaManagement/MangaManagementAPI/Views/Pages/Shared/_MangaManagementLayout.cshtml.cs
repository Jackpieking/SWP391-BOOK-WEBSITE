using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MangaManagementAPI.Views.Pages.Shared
{
    public class _MangaManagementLayout : PageModel
    {
        private readonly ILogger<_MangaManagementLayout> _logger;

        public _MangaManagementLayout(ILogger<_MangaManagementLayout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}