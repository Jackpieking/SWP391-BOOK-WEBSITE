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

    }
}