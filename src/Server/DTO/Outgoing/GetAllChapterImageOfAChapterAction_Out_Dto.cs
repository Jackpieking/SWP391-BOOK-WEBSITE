using System;
using System.Collections.Generic;

namespace DTO.Outgoing;

public class GetAllChapterImageOfAChapterAction_Out_Dto
{
    public string ComicName { get; set; }

    public string ImageURL { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public double ChapterNumber { get; set; }

    public ICollection<ReviewChapterDto> ChapterReviews { get; set; }

    public class ReviewChapterDto
    {
        public string Username { get; set; }

        public string UserAvatar { get; set; }

        public string ChapterComment { get; set; }

        public short ChapterRatingStar { get; set; }

        public DateTime ReviewTime { get; set; }

    }
}
