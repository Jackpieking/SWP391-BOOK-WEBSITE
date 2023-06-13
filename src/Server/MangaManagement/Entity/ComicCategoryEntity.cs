using System;

namespace Entity;

public class ComicCategoryEntity
{
    public Guid CategoryIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public CategoryEntity CategoryEntity { get; set; }

    public ComicEntity ComicEntity { get; set; }
}
