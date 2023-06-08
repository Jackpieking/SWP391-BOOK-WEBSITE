using System;

namespace DataAccessLayer.Data.Entites;

public class ReviewChapterEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public short RatingStar { get; set; }

    public string Comment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserInfoEntity UserInfo { get; set; }

    public ChapterEntity Chapter { get; set; }
}