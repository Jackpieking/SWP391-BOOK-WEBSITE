using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Services;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class LogoutModel : PageModel
{
    private readonly UserService _userService;

    public LogoutModel(UserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> OnGet()
    {
        if (!await _userService.IsUserLoginAsync())
        {
            return RedirectToPage("/Index");
        }

        await _userService.SignOutAsync();

        return RedirectToPage("/Login");
    }
}
