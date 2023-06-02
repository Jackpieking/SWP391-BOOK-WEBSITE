using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.Models;

public class Category
{
	public Guid CategoryIdentifier { get; set; }

	public string Name { get; set; } = string.Empty;

	public string Description { get; set; }

	public ICollection<ComicCategory> ComicCategories { get; set; } = new List<ComicCategory>();
}