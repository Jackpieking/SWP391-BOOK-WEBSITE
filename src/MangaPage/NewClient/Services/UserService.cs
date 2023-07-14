using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NewClient.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NewClient.Services;

public class UserService
{
    private const string BaseUrl = "MangaAPI";
    private readonly ILogger<UserService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserService(
        ILogger<UserService> logger,
        IHttpClientFactory httpClientFactory,
        IHttpContextAccessor httpContextAccessor)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<short> PostNewUserAccountAsync(UserCreationModel user)
    {
        const string GetAllComicEndpointURL = "api/auth/signup";

        _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
                                DateTime.Now,
                                GetAllComicEndpointURL);

        var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

        using var response = await httpClient.PostAsJsonAsync(GetAllComicEndpointURL, user);
        _httpContextAccessor.HttpContext.Response.Headers.Add(
            "Set-Cookie",
            response.Headers.GetValues("Set-Cookie").FirstOrDefault());

        return (short)response.StatusCode;
    }

    public async Task<short> LoginAsync(UserLoginModel user)
    {
        const string GetAllComicEndpointURL = "api/auth/login";

        _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
                                DateTime.Now,
                                GetAllComicEndpointURL);

        var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

        using var response = await httpClient.PostAsJsonAsync(GetAllComicEndpointURL, user);

        var setCookieHeader = response.Headers.GetValues("Set-Cookie").FirstOrDefault();

        if (!Equals(setCookieHeader, null))
        {
            _httpContextAccessor.HttpContext.Response.Headers.Add(
                "Set-Cookie",
                response.Headers.GetValues("Set-Cookie").FirstOrDefault());
        }

        return (short)response.StatusCode;
    }

    public async Task<bool> IsUserLoginAsync()
    {
        const string GetAllComicEndpointURL = "api/auth/is-signin";

        _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
                                DateTime.Now,
                                GetAllComicEndpointURL);

        var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

        using var response = await httpClient.GetAsync(GetAllComicEndpointURL);

        if (response.StatusCode.Equals(HttpStatusCode.OK))
        {
            return true;
        }

        return false;
    }

    public async Task SignOutAsync()
    {
        const string GetAllComicEndpointURL = "api/auth/signout";

        _logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
                                DateTime.Now,
                                GetAllComicEndpointURL);

        var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

        await httpClient.GetAsync(GetAllComicEndpointURL);
    }
}
