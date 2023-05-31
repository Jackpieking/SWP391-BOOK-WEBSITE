using MangaManagementAPI.Data;
using MangaManagementAPI.DTO.Incoming;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Route(template: "login")]
[ApiController]
public class LoginApi : ControllerBase
{
	private readonly MangaContext _context;

	public LoginApi(MangaContext context) => _context = context;

	[HttpPost]
	public async Task<IActionResult> VerifyUserAccount([FromBody] IncomingUserAccountDTO userAccountDTO,
														CancellationToken cancellationToken)
	{
		var foundLoginAccount = await _context
			.UserAccess
			.SingleOrDefaultAsync(predicate: loginAccount =>
				loginAccount.UserName.Equals(userAccountDTO.UserName)
				&& loginAccount.Password.Equals(userAccountDTO.Password)
				, cancellationToken: cancellationToken);

		if (Equals(objA: foundLoginAccount, objB: null))
			return NotFound();

		return Ok();
	}
}
