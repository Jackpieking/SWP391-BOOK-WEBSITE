using System;
using System.Collections.Generic;

namespace NewClient.Models;

public class DisplayChapterImageDto
{
    public string ComicName { get; set; }

    public string ChapNumber { get; set; }

    public Guid LatterChapter { get; set; }

    public Guid FormerChapter { get; set; }

    public ICollection<ChapterImageDto> ChapterImageDtos { get; set; }

    public class ChapterImageDto
    {
        public short ImageNumber { get; set; }

        public string ImageURL { get; set; }
    }
}
