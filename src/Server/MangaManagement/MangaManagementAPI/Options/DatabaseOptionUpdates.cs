using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace DataAccessLayer.Options
{
	public class DatabaseOptionUpdates : IConfigureOptions<DatabaseOptions>
	{
		private const string ConnectionStringKey = "DefaultConnectionString";
		private const string DatabaseOptions = "DatabaseOptions";
		private readonly IConfiguration _configuration;

		public DatabaseOptionUpdates(IConfiguration configuration)
			=> _configuration = configuration;

		public void Configure(DatabaseOptions options)
		{
			options.DefaultConnectionString = _configuration
				.GetConnectionString(name: ConnectionStringKey);

			_configuration
				.GetRequiredSection(key: DatabaseOptions)
				.Bind(instance: options);
		}
	}
}
