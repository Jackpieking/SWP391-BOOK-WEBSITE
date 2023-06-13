using System;

namespace MangaCrawlerApi.Data.Models;

public class Chapter
{
    public string ChapterNumber { get; set; }

    public int ChapterUnlockPrice { get; set; }

    public DateOnly AddedDate { get; set; }
}
