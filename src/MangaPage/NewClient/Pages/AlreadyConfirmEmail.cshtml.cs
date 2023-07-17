using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewClient.Pages;

public class AlreadyConfirmEmailModel : PageModel
{
	public IActionResult OnGet()
	{
		return RedirectToPage("/Index");
	}

	public IActionResult OnGetDaXacNhan()
	{
		HttpContext.Response.Headers.Add("REFRESH", $"{5};URL={"/"}");

		return Page();
	}
}
