using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Models;
using NewClient.Services;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class SignupModel : PageModel
{
    [BindProperty]
    public UserCreationModel UserCreationModel { get; set; }

    private readonly UserService _userService;

    public SignupModel(UserService userService)
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

    public async Task<IActionResult> OnPost()
    {
        var creatingUserResult = await _userService.PostNewUserAccountAsync(user: UserCreationModel);

        if (creatingUserResult == 200)
        {
            return RedirectToPage("/Index");
        }

        ModelState.AddModelError("CreatingError", "Cannot create user");

        return Page();
    }
}
