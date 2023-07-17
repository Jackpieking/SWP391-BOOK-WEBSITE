using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace NewClient.Services;

public class JWTService
{
    public string GetNameClaim(string token)
    {
        JwtSecurityTokenHandler handler = new();

        var jwtSecurityToken = handler.ReadJwtToken(token);

        var tokenName = jwtSecurityToken.Claims.First(claim => claim.Type.Equals(JwtRegisteredClaimNames.Name)).Value;

        return tokenName;
    }
}
