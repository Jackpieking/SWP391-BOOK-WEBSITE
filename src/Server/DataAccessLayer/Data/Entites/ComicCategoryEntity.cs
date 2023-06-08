using System;

namespace DataAccessLayer.Data.Entites;

public class ComicCategoryEntity
{
    public Guid CategoryIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public CategoryEntity Category { get; set; }

    public ComicEntity Comic { get; set; }
}
