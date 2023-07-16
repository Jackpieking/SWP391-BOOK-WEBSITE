using Helper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Models;
using NewClient.Services;
using System;
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

	public IActionResult OnDeleteCurrentUserLoginInToken()
	{
		CacheCollection.Dictionary.Remove("jwt");

		return StatusCode(200, "Remove user auth token successfully");
	}

	public IActionResult OnGet()
	{
		if (CacheCollection.Dictionary.TryGetValue("jwt", out _))
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
