using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NewClient.Models;
using System;
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

	public async Task<AuthResult> RegisterAsync(UserRegistrationRequestDto user)
	{
		const string GetAllComicEndpointURL = "api/auth/register";

		_logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
								DateTime.Now,
								GetAllComicEndpointURL);

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		using var response = await httpClient.PostAsJsonAsync(GetAllComicEndpointURL, user);

		var result = await response.Content.ReadFromJsonAsync<AuthResult>();

		return result;
	}

	public async Task<AuthResult> LoginAsync(UserLoginModel user)
	{
		const string GetAllComicEndpointURL = "api/auth/login";

		_logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
								DateTime.Now,
								GetAllComicEndpointURL);

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		using var response = await httpClient.PostAsJsonAsync(GetAllComicEndpointURL, user);

		var result = await response.Content.ReadFromJsonAsync<AuthResult>();

		return result;
	}

	public async Task<short> ValidateTokenAsync(string authorization)
	{
		const string GetAllComicEndpointURL = "api/auth/validate";

		_logger.LogWarning("[{DateTime.Now}]: Start Calling Api [{GetAllComicEndpointURL}]",
								DateTime.Now,
								GetAllComicEndpointURL);

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		HttpRequestMessage requestMessage = new();

		requestMessage.RequestUri = new($"{httpClient.BaseAddress}{GetAllComicEndpointURL}");
		requestMessage.Headers.Add("Authorization", $"Bearer {authorization}");

		using var response = await httpClient.SendAsync(requestMessage);

		return (short)response.StatusCode;
	}
}
