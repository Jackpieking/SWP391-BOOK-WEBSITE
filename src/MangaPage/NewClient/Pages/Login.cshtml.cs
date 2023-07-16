using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Models;
using NewClient.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class LoginModel : PageModel
{
	private readonly UserService _userService;
	private readonly IDataProtectionProvider _dataProtectionProvider;
	private readonly JWTService _JWTService;

	[BindProperty]
	public UserLoginModel UserLogin { get; set; }

	public LoginModel(UserService userService, IDataProtectionProvider dataProtectionProvider, JWTService jWTService)
	{
		_userService = userService;
		_dataProtectionProvider = dataProtectionProvider;
		_JWTService = jWTService;
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

	public async Task<IActionResult> OnPostAsync()
	{
		var loginResult = await _userService.LoginAsync(UserLogin);

		var dataProtector = _dataProtectionProvider.CreateProtector("authCookie");

		if (loginResult.Result == true)
		{
			TempData["jwt"] = loginResult.Token;

			if (UserLogin.RememberMe)
			{
				CookieBuilder cookieBuilder = new()
				{
					HttpOnly = false,
					Expiration = TimeSpan.FromDays(7),
					Path = "/"
				};

				var cookieOptions = cookieBuilder.Build(HttpContext);

				cookieOptions.SameSite = SameSiteMode.None;

				Response.Cookies.Append(
					key: "authCookie",
					value: $"{dataProtector.Protect(loginResult.Token)}",
					options: cookieOptions);
			}
			else
			{
				TempData["token"] = loginResult.Token;

				HttpContext.Session.SetString(
					loginResult.Token,
					dataProtector.Protect(loginResult.Token));
			}

			return RedirectToPage("/Index");
		}

		return Page();
	}
}
