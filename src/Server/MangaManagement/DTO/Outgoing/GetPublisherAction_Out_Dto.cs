using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTO.Outgoing
{
    public class GetPublisherAction_Out_Dto
    {
        public Guid PublisherIdentifier { get; set; }
        public string PublisherDescription { get; set; }
        public ICollection<PublisherComicOutDto> ComicDto { get; set; } = new List<PublisherComicOutDto>();

        public class PublisherComicOutDto
        {
            public string ComicName { get; set; }
            public string ComicDescription { get; set; }
            public string ComicStatus { get; set; }

        }

    }
}