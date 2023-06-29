using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DTO.Outgoing;
using Model;

namespace Mapper.ModelAndDto
{
    public class PublisherModelToGetPublisherDto : Profile
    {
        public PublisherModelToGetPublisherDto()
        {
            CreateMap<PublisherModel, GetPublisherAction_Out_Dto>()
                .ForMember(destinationMember: destination => destination.ComicDto, 
                options =>
                {
                    options.MapFrom(mapExpression: source => source.ComicModels);
                });
        }
    }
}