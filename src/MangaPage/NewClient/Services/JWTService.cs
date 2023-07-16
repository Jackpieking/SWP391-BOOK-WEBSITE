using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace NewClient.Services;

public class JWTService
{
	public string GetSubcriber(string token)
	{
		JwtSecurityTokenHandler handler = new();

		var jwtSecurityToken = handler.ReadJwtToken(token);

		var tokenSub = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Sub)).Value;

		return tokenSub;
	}
}
