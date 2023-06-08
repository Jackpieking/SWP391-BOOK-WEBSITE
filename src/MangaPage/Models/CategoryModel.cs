using System;
using System.Collections.Generic;

namespace Models;

public class CategoryModel
{
    public Guid CategoryIdentifier { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public ICollection<ComicCategory> ComicCategories { get; set; } = new List<ComicCategory>();
}