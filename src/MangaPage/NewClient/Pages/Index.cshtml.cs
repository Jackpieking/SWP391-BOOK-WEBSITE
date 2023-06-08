using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewClient.Pages;

public class IndexModel : PageModel
{
    private const string MANGA_API = "MangaAPI";
    private readonly ILogger<IndexModel> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public IComicService ComicService { get; set; }

    public IndexModel(
        ILogger<IndexModel> logger,
        IHttpClientFactory httpClientFactory,
        IComicService comicService)
    {

        _logger = logger;
        _httpClientFactory = httpClientFactory;
        ComicService = comicService;
    }

    public async Task OnGet()
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient(name: MANGA_API);

            using var response = await httpClient.GetAsync(requestUri: "api/comic/");
            using var responseContent = response.Content;
            using var stream = await responseContent
                .ReadAsStreamAsync()
                .ConfigureAwait(continueOnCapturedContext: false);
            using TextReader textReader = new StreamReader(stream: stream);
            using JsonReader jsonReader = new JsonTextReader(reader: textReader);

            JsonSerializer jsonSerializer = new();

            ComicService.Comics = jsonSerializer.Deserialize<IEnumerable<ComicModel>>(reader: jsonReader);
        }
        catch (TaskCanceledException TC_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {TC_2.Message}", DateTime.Now, TC_e.Message);
        }
        catch (HttpRequestException HR_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {HR_e.Message}", DateTime.Now, HR_e.Message);
        }
        catch (JsonSerializationException JS_e)
        {
            _logger.LogError("[{DateTime.Now}] - Error: {JS_e.Message}", DateTime.Now, JS_e.Message);
        }
    }
}