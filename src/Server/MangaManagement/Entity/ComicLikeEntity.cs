using System;

namespace Entity;

public class ComicLikeEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public UserEntity UserEntity { get; set; }

    public ComicEntity ComicEntity { get; set; }
}
