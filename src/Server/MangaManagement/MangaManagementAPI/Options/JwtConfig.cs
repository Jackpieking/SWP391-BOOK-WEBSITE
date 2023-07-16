namespace MangaManagementAPI.Options;

public class JwtConfig
{
    public string Issuer { get; set; }

    public string Audience { get; set; }

    public string PrivateKey { get; set; }
}
