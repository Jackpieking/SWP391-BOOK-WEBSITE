using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewClient.Models;
using NewClient.Services;
using NewClient.Services.Mail;
using System.Linq;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class SignupModel : PageModel
{
	[BindProperty]
	public UserCreationModel UserCreationModel { get; set; }

	private readonly IDataProtectionProvider _dataProtectionProvider;
	private readonly ISendMailService _sendMailService;
	private readonly UserService _userService;
	private readonly JWTService _jwtService;

	public SignupModel(
		UserService userService,
		IDataProtectionProvider dataProtectionProvider,
		ISendMailService sendMailService,
		JWTService jwtService)
	{
		_userService = userService;
		_dataProtectionProvider = dataProtectionProvider;
		_sendMailService = sendMailService;
		_jwtService = jwtService;
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

	public async Task<IActionResult> OnPost()
	{
		UserRegistrationRequestDto dto = new()
		{
			Name = UserCreationModel.Username,
			Email = UserCreationModel.UserEmail,
			Password = UserCreationModel.Password
		};

		var creatingUserResult = await _userService.RegisterAsync(user: dto);

		var callbackUrl = Url.Page(
			"/ConfirmEmail",
			pageHandler: "XacNhanEmail",
			values: new
			{
				userId = _jwtService.GetUserIdClaim(creatingUserResult.Token),
				encodedEmailConfirmationToken = _jwtService.GetEncodedEmailConfirmClaimToken(creatingUserResult.Token)
			},
			protocol: Request.Scheme);

		MailContent content = new()
		{
			To = _jwtService.GetEmailClaim(creatingUserResult.Token),
			Subject = "Xác nhận tài khoản !!",
			Body = $"<p>Vui lòng nhấn vào link sau để xác nhận tài khoản: </p><br /><a href=\"{callbackUrl}\">link</a>"
		};

		await _sendMailService.SendMail(content);

		TempData["jwt"] = creatingUserResult.Token;

		callbackUrl = Url.Page(
			"/ConfirmAccount",
			pageHandler: "XacNhanTaiKhoan",
			values: null,
			protocol: Request.Scheme);

		return Redirect(callbackUrl);
	}
}
