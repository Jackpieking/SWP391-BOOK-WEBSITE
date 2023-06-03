using System;

namespace MangaManagementAPI.Data.Models;

public class ComicCategory
{
	public Guid CategoryIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public Category Category { get; set; } = new();

	public Comic Comic { get; set; } = new();
}
