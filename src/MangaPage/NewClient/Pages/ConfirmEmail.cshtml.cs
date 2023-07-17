using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Services;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class ConfirmEmailModel : PageModel
{
	private readonly IDataProtectionProvider _dataProtectionProvider;
	private readonly UserService _userService;

	public ConfirmEmailModel(
		IDataProtectionProvider dataProtectionProvider,
		UserService userService)
	{
		_dataProtectionProvider = dataProtectionProvider;
		_userService = userService;
	}

	public IActionResult OnGet()
	{
		return RedirectToPage("/Login");
	}

	public async Task<IActionResult> OnGetXacNhanEmail(
		[FromQuery] string userId,
		[FromQuery] string encodedEmailConfirmationToken)
	{
		if (Equals(userId, null) || Equals(encodedEmailConfirmationToken, null))
		{
			return RedirectToPage("/Login");
		}

		var statusCode = await _userService.ConfirmEmailAsync(userId, encodedEmailConfirmationToken);

		if (statusCode != StatusCodes.Status200OK)
		{
			var page1 = Url.Page("/AlreadyConfirmEmail", "DaXacNhan", null, Request.Scheme);

			return Redirect(page1);
		}

		var token = TempData["jwt"].ToString();
		var dataProtector = _dataProtectionProvider.CreateProtector("authCookie");

		TempData["token"] = token;

		HttpContext.Session.SetString(
			token,
			dataProtector.Protect(token));

		var page2 = Url.Page("/ConfirmEmailSuccess", "ThanhCong", null, Request.Scheme);

		return Redirect(page2);
	}
}
