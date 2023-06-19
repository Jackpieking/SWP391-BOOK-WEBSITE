using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace MangaManagementAPI.Controllers;

[Route(template: "api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    [HttpGet(template: "ComicAvatar/{imgName}")]
    public IActionResult GetAComicAvatar([FromRoute] string imgName)
    {
        return PhysicalFile(
            physicalPath: Path.Combine(
                path1: "C:",
                "Comic",
                "ComicAvatars",
                FormatComicName(imgName)),
            contentType: "image/jpeg");
    }

    [HttpGet("ChapterImage")]
    public IActionResult GetAChapterImage(string imgName, string comicName, string chapterNumber)
    {
        return PhysicalFile(
            physicalPath: Path.Combine(
                "C:",
                "Comic",
                "ComicImages",
                FormatComicName(comicName),
                $"Chap_{chapterNumber}",
                imgName),
            contentType: "image/jpeg");
    }

    private static string FormatComicName(string comicName)
    {
        return comicName
            .Replace(oldValue: "\"", newValue: "")
            .Replace(oldValue: "\\", newValue: "")
            .Replace(oldValue: "//", newValue: "")
            .Replace(oldValue: ":", newValue: "")
            .Replace(oldValue: "*", newValue: "")
            .Replace(oldValue: "?", newValue: "")
            .Replace(oldValue: "<", newValue: "")
            .Replace(oldValue: ">", newValue: "")
            .Replace(oldValue: "|", newValue: "")
            .Replace(oldChar: ' ', newChar: '_');
    }
}
