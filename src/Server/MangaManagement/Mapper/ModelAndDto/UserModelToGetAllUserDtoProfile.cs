using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        }
    }
}