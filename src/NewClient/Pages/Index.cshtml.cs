using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;

namespace NewClient.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private const string MANGA_API = "MangaAPI";

    public IndexModel(
        ILogger<IndexModel> logger,
        IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public void OnGet()
    {
        _logger.LogInformation(message: $"[{DateTime.Now}]: Start -> HTTP Request GET On Index page");

        var httpClient = _httpClientFactory.CreateClient(name: MANGA_API);



        _logger.LogInformation(message: $"[{DateTime.Now}]: End -> HTTP Request GET On Index page");
    }
}