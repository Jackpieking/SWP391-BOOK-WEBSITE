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
    private const string BaseUrl = "MangaAPI";
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
        const string GetAllComicEndpointURL = "api/comic";

        try
        {
            _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
                                DateTime.Now,
                                GetAllComicEndpointURL);

            var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

            using var response = await httpClient.GetAsync(requestUri: GetAllComicEndpointURL);

            _logger.LogWarning("[{DateTime.Now}]: End Calling Api [{GetAllComicEndpointURL}]",
                                DateTime.Now,
                                GetAllComicEndpointURL);

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

    public async Task<ComicWithPublisherModel> GetComicDetailFromApiAsync(Guid comicIdentifier)
    {
        var GetComicDetailEndpointURL = $"api/comic/{comicIdentifier}";

        try
        {
            _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetComicDetailEndpointURL}]",
                                DateTime.Now,
                                GetComicDetailEndpointURL);

            var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

            using var response = await httpClient.GetAsync(requestUri: GetComicDetailEndpointURL);

            _logger.LogWarning("[{DateTime.Now}]: End Calling Api [{GetComicDetailEndpointURL}]",
                                DateTime.Now,
                                GetComicDetailEndpointURL);

            using var responseContent = response.Content;
            using var stream = await responseContent
                .ReadAsStreamAsync()
                .ConfigureAwait(continueOnCapturedContext: false);
            using TextReader textReader = new StreamReader(stream: stream);
            using JsonReader jsonReader = new JsonTextReader(reader: textReader);

            JsonSerializer jsonSerializer = new();

            return jsonSerializer.Deserialize<ComicWithPublisherModel>(reader: jsonReader);
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
