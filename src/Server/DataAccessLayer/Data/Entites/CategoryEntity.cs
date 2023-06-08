using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class CategoryEntity
{
    public Guid CategoryIdentifier { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public ICollection<ComicCategoryEntity> ComicCategories { get; set; } = new List<ComicCategoryEntity>();
}