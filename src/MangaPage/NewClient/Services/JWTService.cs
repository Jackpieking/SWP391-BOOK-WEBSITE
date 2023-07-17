using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace NewClient.Services;

public class JWTService
{
	public string GetNameClaim(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var nameClaim = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Name)).Value;

		return nameClaim;
	}

	public string GetUserIdClaim(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var userIdClaim = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Sub)).Value;

		return userIdClaim;
	}

	public string GetEmailClaim(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var emailClaim = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Email)).Value;

		return emailClaim;
	}

	public string GetEmailConfirmClaim(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var isEmailConfirm = jwtSecurityToken.Claims.First(claim => claim.Type.Equals("email-cfr")).Value;

		return isEmailConfirm;
	}

	public string GetEncodedEmailConfirmClaimToken(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var encodedEmailConfirmToken = jwtSecurityToken.Claims.First(claim => claim.Type.Equals("email-cfr-tk")).Value;

		return encodedEmailConfirmToken;
	}
}
