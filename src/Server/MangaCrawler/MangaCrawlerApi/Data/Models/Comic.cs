using System;
using System.Collections.Generic;

namespace MangaCrawlerApi.Data.Models;

public class Comic
{
    public string ComicTitle { get; set; }

    public string ComicDescription { get; set; }

    public DateOnly ComicPublishedDate { get; set; }

    public ushort ComicLatestChapter { get; set; }

    public string ComicPublisher { get; set; }

    public string ComicStatus { get; set; }

    public IEnumerable<string> ComicTags { get; set; }
}
