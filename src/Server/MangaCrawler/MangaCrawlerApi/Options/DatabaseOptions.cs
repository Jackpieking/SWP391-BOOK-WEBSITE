namespace MangaCrawlerApi.Options;

public class DatabaseOptions
{
    public string DefaultConnectionString { get; set; } = string.Empty;

    public int MaxRetryCount { get; set; }

    public int CommandTimeOut { get; set; }

    public bool EnableDetailedErrors { get; set; }

    public bool EnableSensitiveDataLogging { get; set; }

    public bool EnableServiceProviderCaching { get; set; }

    public bool EnableThreadSafetyCheck { get; set; }

}
