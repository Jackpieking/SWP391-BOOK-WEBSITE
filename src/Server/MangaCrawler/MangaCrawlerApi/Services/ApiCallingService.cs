using MangaCrawlerApi.DTOs.Outgoing;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MangaCrawlerApi.Services;

public class ApiCallingService
{
	private readonly IHttpClientFactory _httpClientFactory;

	public ApiCallingService(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="imageUrl"></param>
	/// <param name="imagePath"></param>
	/// <param name="httpClientName"></param>
	/// <returns></returns>
	public async Task DownloadAndSaveImageAsync(
		string imageUrl,
		string imagePath,
		string httpClientName)
	{
		var httpclient = _httpClientFactory.CreateClient(name: httpClientName);

		Uri uri = new(uriString: imageUrl);
		var fileExtension = Path.GetExtension(path: uri.GetLeftPart(part: UriPartial.Path));

		await using var stream = await httpclient.GetStreamAsync(requestUri: imageUrl);

		var chapterImageFilePath = $"{imagePath}{fileExtension}";

		if (File.Exists(path: chapterImageFilePath))
		{
			File.Delete(path: chapterImageFilePath);
		}

		await using var fileStream = File.Create(path: $"{imagePath}{fileExtension}");
		await stream.CopyToAsync(destination: fileStream);
	}

	public async Task UpdateComicToDatabaseAsync(UpdateCrawlDataToDatabaseAction_Out_Dto dto)
	{
		var httpclient = _httpClientFactory.CreateClient(name: "MangaApi");

		const string UpdateEndpointUrl = "api/update/comic";

		Console.WriteLine(value: $"Start calling api: path: [{UpdateEndpointUrl}]");

		using var response = await httpclient.PutAsJsonAsync(requestUri: UpdateEndpointUrl, value: dto);

		if (!response.IsSuccessStatusCode)
		{
			throw new TaskCanceledException(message: $"Status code: {(short)response.StatusCode}");
		}

		Console.WriteLine(value: $"End calling api: Path: [{UpdateEndpointUrl}] - Status Code: {(short)response.StatusCode}");
	}
}
