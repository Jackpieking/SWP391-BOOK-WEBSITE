using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Model;
using static DTO.Outgoing.GetAllUserDetailsAction_Out_Dto;

namespace Mapper.ModelAndDto
{
    public class ReadingHistoryModelToReadingHistoryDto : Profile
    {
        public ReadingHistoryModelToReadingHistoryDto()
        {
            CreateMap<ReadingHistoryModel, ReadingHistoryDto>()
            
                .ForMember(destinationMember: destination => destination.ComicName,
                options => 
                {
                    options.MapFrom(mapExpression: source => source.ChapterModel.ComicModel.ComicName);
                });
        }
    }
}