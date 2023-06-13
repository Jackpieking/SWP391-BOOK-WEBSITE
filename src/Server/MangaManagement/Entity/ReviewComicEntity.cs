using System;

namespace Entity;

public class ReviewComicEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public short ComicRatingStar { get; set; }

    public string ComicComment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserEntity UserEntity { get; set; }

    public ComicEntity ComicEntity { get; set; }
}