using System;

namespace Models;

public class ComicCategory
{
    public Guid CategoryIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public CategoryModel Category { get; set; }

    public ComicModel Comic { get; set; }
}
