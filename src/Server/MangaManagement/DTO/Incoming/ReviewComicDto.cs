using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Incoming
{
    public class ReviewComicDto
    {
        public Guid UserIdentifier { get; set; }

        public string Username { get; set; }

        public Guid ComicIdentifier { get; set; }

        public short ComicRatingStar { get; set; }

        public string ComicComment { get; set; }

        public DateTime ReviewTime { get; set; }

        public string ComicName { get; set; }

        public string ComicStatus { get; set; }
    }
}
