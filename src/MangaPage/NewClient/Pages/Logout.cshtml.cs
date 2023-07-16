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

		if (Equals(authCookie, null) && Equals(TempData["token"], null))
		{
			return RedirectToPagePermanent("/Index");
		}

		HttpContext.Response.Headers.Add("REFRESH", $"{5};URL={"/"}");

		return Page();
	}
}
