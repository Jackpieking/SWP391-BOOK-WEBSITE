using System;

namespace Entity;

public class ReviewComicEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public short ComicRatingStar { get; set; }

    public string ComicComment { get; set; }

    public DateTime ReviewTime { get; set; }

    public virtual UserEntity UserEntity { get; set; }

    public virtual ComicEntity ComicEntity { get; set; }
}