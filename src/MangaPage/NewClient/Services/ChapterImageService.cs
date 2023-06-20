using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewClient.Services;

public class ChapterImageService
{
    private const string BaseUrl = "MangaAPI";
    private readonly ILogger<ChapterImageService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public ChapterImageService(
        ILogger<ChapterImageService> logger,
        IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<int> GetTotalNumberOfImagesOfAChapter(Guid chapterIdentifier)
    {
        var GetAllChapterImageOfAChapterEndpointURL = $"api/ChapterImage/Total/{chapterIdentifier}";

        try
        {
            _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetComicDetailEndpointURL}]",
                                DateTime.Now,
                                GetAllChapterImageOfAChapterEndpointURL);

            var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

            using var response = await httpClient.GetAsync(requestUri: GetAllChapterImageOfAChapterEndpointURL);

            _logger.LogWarning("[{DateTime.Now}]: End Calling Api [{GetComicDetailEndpointURL}]",
                                DateTime.Now,
                                GetAllChapterImageOfAChapterEndpointURL);

            using var responseContent = response.Content;
            using var stream = await responseContent
                .ReadAsStreamAsync()
                .ConfigureAwait(continueOnCapturedContext: false);
            using TextReader textReader = new StreamReader(stream: stream);
            using JsonReader jsonReader = new JsonTextReader(reader: textReader);

            JsonSerializer jsonSerializer = new();

            return jsonSerializer.Deserialize<int>(reader: jsonReader);
        }
        catch (TaskCanceledException)
        {
            throw;
        }
        catch (HttpRequestException)
        {
            throw;
        }
        catch (JsonSerializationException)
        {
            throw;
        }
    }
}
