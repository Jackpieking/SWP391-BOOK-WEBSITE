using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace MangaManagementAPI.Options;

public class JwtConfigUdate : IConfigureOptions<JwtConfig>
{
    private readonly IConfiguration _configuration;

    public JwtConfigUdate(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(JwtConfig options)
    {
        _configuration.GetRequiredSection("JwtConfig").Bind(options);
    }
}
