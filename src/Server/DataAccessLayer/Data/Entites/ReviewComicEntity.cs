using System;

namespace DataAccessLayer.Data.Entites;

public class ReviewComicEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public short RatingStar { get; set; }

    public string Comment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserInfoEntity UserInfo { get; set; }

    public ComicEntity Comic { get; set; }
}