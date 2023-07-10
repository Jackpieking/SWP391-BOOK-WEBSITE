using System;

namespace Entity;

public class ComicCategoryEntity
{
    public Guid CategoryIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public virtual CategoryEntity CategoryEntity { get; set; }

    public virtual ComicEntity ComicEntity { get; set; }
}
