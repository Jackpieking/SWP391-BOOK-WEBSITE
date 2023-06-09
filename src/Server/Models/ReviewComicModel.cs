using System;

namespace Model;

public class ReviewComicModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public short ComicRatingStar { get; set; }

    public string ComicComment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserModel UserModel { get; set; }

    public ComicModel ComicModel { get; set; }
}