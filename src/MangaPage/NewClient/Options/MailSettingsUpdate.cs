using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace NewClient.Options;

public class MailSettingsUpdate : IConfigureOptions<MailSettings>
{
	private readonly IConfiguration _configuration;

	public MailSettingsUpdate(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	public void Configure(MailSettings options)
	{
		_configuration.GetRequiredSection(nameof(MailSettings)).Bind(options);
	}
}
