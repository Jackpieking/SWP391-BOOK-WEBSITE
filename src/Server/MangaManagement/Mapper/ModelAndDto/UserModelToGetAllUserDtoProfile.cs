using AutoMapper;
using DTO.Incoming;
using DTO.Outgoing;
using Model;

namespace Mapper.ModelAndDto
{
    public class UserModelToGetAllUserDtoProfile : Profile
    {
        public UserModelToGetAllUserDtoProfile()
        {
            CreateMap<UserModel, GetAllUserAction_Out_Dto>()
                .ForMember(destinationMember: destination => destination.PublisherDto,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.PublisherModel);
                })
                .ReverseMap();

            CreateMap<UserModel, UserUpdateDto>().ReverseMap();
        }
    }
}