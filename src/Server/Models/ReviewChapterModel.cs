
using System;

namespace Model;

public class ReviewChapterModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public short ChapterRatingStar { get; set; }

    public string ChapterComment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserModel UserModel { get; set; }

    public ChapterModel ChapterModel { get; set; }
}