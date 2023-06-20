using System;

namespace DTO;

public class GetAllComicAction_Out_Dto
{
    public Guid ComicIdentifier { get; set; }

    public string ComicName { get; set; }

    public DateOnly ComicPublishDate { get; set; }

    public string ComicLatestChapter { get; set; }

    public string ComicAvatar { get; set; }

    public int ReadersCounts { get; set; }

    public int ReviewCounts { get; set; }

    public DateTime LastestComicReviewDate { get; set; }
}
