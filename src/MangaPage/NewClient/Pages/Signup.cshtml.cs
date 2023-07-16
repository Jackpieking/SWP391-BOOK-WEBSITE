using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Models;
using NewClient.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class SignupModel : PageModel
{
	[BindProperty]
	public UserCreationModel UserCreationModel { get; set; }

	private readonly IDataProtectionProvider _dataProtectionProvider;

	private readonly UserService _userService;

	public SignupModel(UserService userService, IDataProtectionProvider dataProtectionProvider)
	{
		_userService = userService;
		_dataProtectionProvider = dataProtectionProvider;
	}

	public IActionResult OnGet()
	{
		var authCookie = HttpContext
			.Request
			.Cookies
			.FirstOrDefault(cookie => cookie.Key.StartsWith("authCookie"))
			.Value;

		var token = TempData["token"];
		TempData.Keep("token");

		string authSession = null;

		if (!Equals(token, null))
		{
			authSession = HttpContext
				.Session
				.GetString(token.ToString());
		}

		if (!Equals(authCookie, null) || !Equals(authSession, null))
		{
			return RedirectToPage("/Index");
		}

		return Page();
	}

	public async Task<IActionResult> OnPost()
	{
		UserRegistrationRequestDto dto = new()
		{
			Name = UserCreationModel.Username,
			Email = UserCreationModel.UserEmail,
			Password = UserCreationModel.Password
		};

		var creatingUserResult = await _userService.RegisterAsync(user: dto);
		var dataProtector = _dataProtectionProvider.CreateProtector("authCookie");

		if (creatingUserResult.Result == true)
		{
			TempData["token"] = creatingUserResult.Token;

			HttpContext.Session.SetString(
				creatingUserResult.Token,
				dataProtector.Protect(creatingUserResult.Token));

			return RedirectToPage("/Index");
		}

		ModelState.AddModelError("CreatingError", "Cannot create user");

		return Page();
	}
}
