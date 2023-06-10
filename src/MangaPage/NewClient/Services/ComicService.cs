using Microsoft.Extensions.Logging;
using NewClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewClient.Services;

public class ComicService
{
    private const string MANGA_API = "MangaAPI";
    private readonly ILogger<ComicService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public ComicService(
        ILogger<ComicService> logger,
        IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IEnumerable<ComicModel>> GetAllComicModelFromApiAsync()
    {
        try
        {
            _logger.LogCritical("[{DateTime.Now}]: Start Calling Api [{MANGA_API}]",
                                DateTime.Now,
                                MANGA_API);

            var httpClient = _httpClientFactory.CreateClient(name: MANGA_API);

            using var response = await httpClient.GetAsync(requestUri: "api/comic/");

            _logger.LogCritical("[{DateTime.Now}]: End Calling Api [{MANGA_API}]",
                                DateTime.Now,
                                MANGA_API);

            using var responseContent = response.Content;
            using var stream = await responseContent
                .ReadAsStreamAsync()
                .ConfigureAwait(continueOnCapturedContext: false);
            using TextReader textReader = new StreamReader(stream: stream);
            using JsonReader jsonReader = new JsonTextReader(reader: textReader);

            JsonSerializer jsonSerializer = new();

            return jsonSerializer.Deserialize<IEnumerable<ComicModel>>(reader: jsonReader);
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
