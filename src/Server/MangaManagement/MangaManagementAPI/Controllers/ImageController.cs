using Microsoft.AspNetCore.Mvc;

namespace MangaManagementAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
	[HttpGet]
	public IActionResult GetAnImage()
	{
		return PhysicalFile(string.Empty, "image/jpeg");
	}
}
