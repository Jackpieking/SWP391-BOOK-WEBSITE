using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Model;
using static DTO.Outgoing.GetAllUserDetailsAction_Out_Dto;

namespace Mapper.ModelAndDto
{
    public class BuyingHistoryModelToReadingHistoryDto : Profile
    {
        public BuyingHistoryModelToReadingHistoryDto()
        {
            CreateMap<BuyingHistoryModel, BuyingHistoryDto>()
                .ForMember(destinationMember: destination => destination.ComicName,
                options => 
                {
                    options.MapFrom(mapExpression: source => source.ChapterModel.ComicModel.ComicName);
                })

                .ForMember(destinationMember: destination => destination.ChapterNumber,
                options =>{
                    options.MapFrom(mapExpression: source => source.ChapterModel.ChapterNumber);
                })

                .ForMember(destinationMember: destination => destination.ChapterUnlockPrice,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.ChapterModel.ChapterUnlockPrice);
                });
        }
    }
}