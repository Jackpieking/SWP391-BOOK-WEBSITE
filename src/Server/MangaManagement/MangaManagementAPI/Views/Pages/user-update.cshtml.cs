using BusinessLogicLayer.Services;
using DTO.Outgoing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
	public class UserUpdate : PageModel
	{
		private readonly ILogger<UserUpdate> _logger;
		private readonly UserManagementService _userManagementService;
		public UserUpdate(ILogger<UserUpdate> logger, UserManagementService userManagementService)
		{
			_userManagementService = userManagementService;
			_logger = logger;
		}

		public GetAllUserAction_Out_Dto User { get; set; }

		public async Task<IActionResult> OnPostUpdateUser()
		{
			return Page();
		}
	}
}