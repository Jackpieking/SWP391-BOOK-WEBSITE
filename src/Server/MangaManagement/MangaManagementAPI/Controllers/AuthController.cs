using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly EntityManagementService _entityManagementService;
    private readonly ILogger<AuthController> _logger;
    private readonly IMapper _mapper;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AuthController(
        EntityManagementService entityManagementService,
        ILogger<AuthController> logger,
        IMapper mapper,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager)
    {
        _entityManagementService = entityManagementService;
        _logger = logger;
        _mapper = mapper;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet("is-signin")]
    public async Task<IActionResult> IsUserSignedInAsync()
    {
        //if (HttpContext.Request.Cookies[".AspNetCore.Identity.Application"] is null)
        //{
        //    await _signInManager.SignOutAsync();
        //}

        if (_signInManager.IsSignedIn(User))
        {
            return Ok();
        }

        return BadRequest("User is not signed in!!");
    }

    [HttpGet("signout")]
    public async Task<IActionResult> SignUserOutAsync()
    {
        await _signInManager.SignOutAsync();

        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> ValidateUserAndLoginAsync([FromBody] UserLoginDto user)
    {
        var loginResult = await _signInManager.PasswordSignInAsync(
            user.Username,
            user.Password,
            user.RememberMe,
            false);

        if (loginResult.Succeeded)
        {
            return Ok();
        }

        if (loginResult.Equals(Microsoft.AspNetCore.Identity.SignInResult.Failed))
        {
            return NotFound();
        }

        return BadRequest("Cannot login");
    }

    [HttpPost("signup")]
    public async Task<IActionResult> ValidateAndCreateUserAsync([FromBody] UserCreationDto dto)
    {
        //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        IdentityUser user = new() { UserName = dto.Username, Email = dto.UserEmail };

        var result = await _userManager.CreateAsync(user, dto.Password);

        if (result.Succeeded)
        {
            _logger.LogInformation("User created a new account with password.");

            await _signInManager.SignInAsync(user, false);

            //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            //var callbackUrl = Url.Page(
            //    "/Account/ConfirmEmail",
            //    pageHandler: null,
            //    values: new { area = "Identity", userId = user.Id, code = code },
            //    protocol: Request.Scheme);

            //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
            //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            //if (_userManager.Options.SignIn.RequireConfirmedAccount)
            //{
            //    return RedirectToPage("RegisterConfirmation",
            //                          new { email = Input.Email });
            //}
            //else
            //{
            //    await _signInManager.SignInAsync(user, isPersistent: false);
            //    return LocalRedirect(returnUrl);
            //}

            return Ok();
        }

        return BadRequest();
    }
}
