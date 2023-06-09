using System;
using System.Collections.Generic;

namespace Entity;

public class CategoryEntity
{
    public Guid CategoryIdentifier { get; set; }

    public string CategoryName { get; set; }

    public string CategoryDescription { get; set; }

    public ICollection<ComicCategoryEntity> ComicCategoryEntities { get; set; } = new List<ComicCategoryEntity>();
}