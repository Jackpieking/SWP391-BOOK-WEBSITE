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

	[BindProperty]
	public UserLoginModel UserLogin { get; set; }

	public LoginModel(UserService userService, IDataProtectionProvider dataProtectionProvider)
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

	public async Task<IActionResult> OnPostAsync()
	{
		var loginResult = await _userService.LoginAsync(UserLogin);

		if (loginResult.Errors is not null &&
			loginResult.Errors.FirstOrDefault(error => error.Equals("Email is not confirm")) is not null)
		{
			ModelState.AddModelError("Login fail", "Tài khoản chưa xác thực email !!");

			return Page();
		}

		if (loginResult.Result == true)
		{
			var dataProtector = _dataProtectionProvider.CreateProtector("authCookie");

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

		ModelState.AddModelError("Login fail", "Tài khoản hoặc mật khẩu không chính xác !!");

		return Page();
	}
}
