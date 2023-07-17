using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NewClient.Models;
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
		const string registerEndpointUrl = "api/auth/register";

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		using var response = await httpClient.PostAsJsonAsync(registerEndpointUrl, user);

		var result = await response.Content.ReadFromJsonAsync<AuthResult>();

		return result;
	}

	public async Task<AuthResult> LoginAsync(UserLoginModel user)
	{
		const string loginEndpointUrl = "api/auth/login";

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		using var response = await httpClient.PostAsJsonAsync(loginEndpointUrl, user);

		var result = await response.Content.ReadFromJsonAsync<AuthResult>();

		return result;
	}

	public async Task<short> ValidateTokenAsync(string authorization)
	{
		const string validateTokenEndpointUrl = "api/auth/validate";

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		HttpRequestMessage requestMessage = new()
		{
			RequestUri = new($"{httpClient.BaseAddress}{validateTokenEndpointUrl}")
		};
		requestMessage.Headers.Add("Authorization", $"Bearer {authorization}");

		using var response = await httpClient.SendAsync(requestMessage);

		return (short)response.StatusCode;
	}

	public async Task<short> ConfirmEmailAsync(string userId, string encodedEmailConfirmToken)
	{
		var emailConfirmEndpointUrl = $"api/auth/confirm-email/{userId}/{encodedEmailConfirmToken}";

		var httpClient = _httpClientFactory.CreateClient(name: BaseUrl);

		using var response = await httpClient.GetAsync(emailConfirmEndpointUrl);

		return (short)response.StatusCode;
	}
}
