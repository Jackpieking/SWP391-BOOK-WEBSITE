using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helper.DefinedEnums;

namespace DTO.Outgoing
{
    public class GetAllUserAction_Out_Dto
    {
        public Guid UserIdentifier { get; set; }

        public string Username { get; set; }

        public string UserFullName { get; set; }

        public DefinedGender UserGender { get; set; }

        public DateOnly UserBirthday { get; set; }

        public string UserPhoneNumber { get; set; }

        public string UserEmail { get; set; }

        public int UserAccountBalance { get; set; }

        public string UserAvatar { get; set; }
    }
}