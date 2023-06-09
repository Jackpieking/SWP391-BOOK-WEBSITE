using System;

namespace DTO;

public class GetAllComicAction_Out_Dto
{
    public Guid ComicIdentifier { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Avatar { get; set; }

    public DateOnly PublishDate { get; set; }

    public double LatestChapter { get; set; }
}
