﻿namespace DTO;

public class GetAllComicAction_Out_Dto
{
    public string ComicName { get; set; }

    public double ComicLatestChapter { get; set; }

    public int ReviewCount { get; set; }

    public string ComicAvatar { get; set; }

    public int NumberOfReaderHasRead { get; set; }
}
