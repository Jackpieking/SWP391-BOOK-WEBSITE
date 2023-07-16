using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace NewClient.Pages;

public class LogoutModel : PageModel
{
	public IActionResult OnGet()
	{
		var authCookie = HttpContext
			.Request
			.Cookies
			.FirstOrDefault(cookie => cookie.Key.StartsWith("authCookie"))
			.Value;

		var token = TempData["token"];
		string authSession = null;

		if (!Equals(token, null))
		{
			authSession = HttpContext
				.Session
				.GetString(token.ToString());
		}

		if (Equals(authCookie, null) && Equals(authSession, null))
		{
			return RedirectToPage("/Index");
		}

		HttpContext.Response.Headers.Add("REFRESH", $"{5};URL={"/"}");

		return Page();
	}
}
