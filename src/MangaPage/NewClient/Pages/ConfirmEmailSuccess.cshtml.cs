using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewClient.Pages;

public class ConfirmEmailSuccessModel : PageModel
{
	public IActionResult OnGet()
	{
		return RedirectToPage("/Index");
	}

	public IActionResult OnGetThanhCong()
	{
		HttpContext.Response.Headers.Add("REFRESH", $"{5};URL={"/"}");

		return Page();
	}
}
