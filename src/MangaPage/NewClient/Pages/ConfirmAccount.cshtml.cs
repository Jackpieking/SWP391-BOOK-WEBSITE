using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewClient.Pages;

public class ConfirmAccountModel : PageModel
{
	public IActionResult OnGet()
	{
		return RedirectToPage("/Index");
	}

	public IActionResult OnGetXacNhanTaiKhoan()
	{
		HttpContext.Response.Headers.Add("REFRESH", $"{5};URL={"/auth/login"}");

		return Page();
	}
}
