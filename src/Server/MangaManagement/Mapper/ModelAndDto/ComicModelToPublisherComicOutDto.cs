using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Model;
using static DTO.Outgoing.GetPublisherAction_Out_Dto;

namespace Mapper.ModelAndDto
{
    public class ComicModelToPublisherComicOutDto : Profile
    {
        public ComicModelToPublisherComicOutDto()
        {
            CreateMap<ComicModel, PublisherComicOutDto>();
        }
    }
}