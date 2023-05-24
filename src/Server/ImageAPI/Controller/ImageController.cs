using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ImageAPI.Controller;

[Produces(contentType: MediaTypeNames.Application.Json)]
[Consumes(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]

public class ImageController : ControllerBase
{
	[HttpGet]
	public IActionResult GetImageFromOneDriveStorage() => Ok(value: string.Empty);
}
