using System;

namespace DataAccessLayer.Models;

public class ComicCategoryModel
{
	public Guid CategoryIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public CategoryModel Category { get; set; }

	public ComicModel Comic { get; set; }
}
