using System;

namespace MangaManagementAPI.Data.Models;

public class ChapterImage
{
	public Guid ImageIdentifier { get; set; }

	public short ImageNumber { get; set; }

	public string ImageURL { get; set; }

	public Guid ChapterIdentifier { get; set; }

	public Chapter Chapter { get; set; }
}