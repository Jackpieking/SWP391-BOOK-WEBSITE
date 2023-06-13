using System.Net.Http;

namespace MangaCrawlerApi.Services;

public class UpdateCrawlDataToDatabaseService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public UpdateCrawlDataToDatabaseService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public void UpdateAllComicToDatabase()
    {

    }
}
