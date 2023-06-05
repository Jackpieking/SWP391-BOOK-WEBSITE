using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Models;

public class CategoryModel
{
	public Guid CategoryIdentifier { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public ICollection<ComicCategoryModel> ComicCategories { get; set; } = new List<ComicCategoryModel>();
}