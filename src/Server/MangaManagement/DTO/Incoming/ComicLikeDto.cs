using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Incoming
{
    public class ComicLikeDto
    {
        public Guid UserIdentifier { get; set; }
        public Guid ComicIdentifier { get; set; }
        public string Username { get; set; }
        public string ComicName { get; set; }
    }
}
