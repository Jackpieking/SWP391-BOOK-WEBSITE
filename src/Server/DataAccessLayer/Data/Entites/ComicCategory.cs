using System;

namespace MangaManagementAPI.Data.Entites;

public class ComicCategory
{
	public Guid CategoryIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public Category Category { get; set; }

	public Comic Comic { get; set; }
}
