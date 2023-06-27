using AutoMapper;
using DTO.Outgoing;
using Model;

namespace Mapper.ModelAndDto
{
    public class UserModelToGetAllUserDetailsDtoProfile : Profile
    {
        public UserModelToGetAllUserDetailsDtoProfile()
        {
            CreateMap<UserModel, GetAllUserDetailsAction_Out_Dto>();
        }
    }
}