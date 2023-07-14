using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Incoming
{
    public class ReviewChapterDto
    {
        public Guid UserIdentifier { get; set; }

        public Guid ChapterIdentifier { get; set; }

        public short ChapterRatingStar { get; set; }

        public string ChapterComment { get; set; }

        public DateTime ReviewTime { get; set; }

        public string Username { get; set; }

        public string ChapterNumber { get; set; }

        public string ComicName { get; set; }
    }
}
