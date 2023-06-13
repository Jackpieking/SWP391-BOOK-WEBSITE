using System;
using System.Collections.Generic;

namespace MangaCrawlerApi.Data.Models;

public class Comic
{
    public string ComicName { get; set; }

    public string ComicDescription { get; set; }

    public DateOnly ComicPublishedDate { get; set; }

    public string ComicPublisher { get; set; }

    public string ComicStatus { get; set; }

    public IEnumerable<string> ComicTags { get; set; }

    public IEnumerable<Chapter> ComicChapters { get; set; }
}
