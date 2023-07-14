using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Models;
using NewClient.Services;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class LoginModel : PageModel
{
    private readonly UserService _userService;

    [BindProperty]
    public UserLoginModel UserLogin { get; set; }

    public LoginModel(UserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        if (await _userService.IsUserLoginAsync())
        {
            return RedirectToPage("/Index");
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var loginResult = await _userService.LoginAsync(UserLogin);

        if (loginResult == 404)
        {
            ModelState.AddModelError("Login Error", "Cannot login");

            return Page();
        }

        if (loginResult == 400)
        {
            ModelState.AddModelError("UserError", "Cannot found user");

            return Page();
        }

        return RedirectToPage("/Index");
    }
}
