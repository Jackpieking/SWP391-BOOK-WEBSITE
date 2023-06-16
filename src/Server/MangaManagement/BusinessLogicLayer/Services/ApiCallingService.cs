using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services;

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

		await using var fileStream = File.Create(path: chapterImageFilePath);
		await stream.CopyToAsync(destination: fileStream);
	}
}
