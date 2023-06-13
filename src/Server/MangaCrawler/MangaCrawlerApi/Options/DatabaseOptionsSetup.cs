using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace MangaCrawlerApi.Options;

public class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
{
    private const string DefaultConnectionString = "DefaultConnectionString";
    private const string DatabaseOptions = "DatabaseOptions";
    private readonly IConfiguration _configuration;

    public DatabaseOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(DatabaseOptions options)
    {
        options.DefaultConnectionString = _configuration
            .GetConnectionString(name: DefaultConnectionString);

        _configuration
            .GetRequiredSection(key: DatabaseOptions)
            .Bind(instance: options);
    }
}
