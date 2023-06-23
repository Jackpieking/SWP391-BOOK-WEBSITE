using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Model;
using static DTO.Outgoing.GetAllUserDetailsAction_Out_Dto;

namespace Mapper.ModelAndDto
{
    public class ReviewChapterToReviewChapterDtoForUser : Profile
    {
        public ReviewChapterToReviewChapterDtoForUser()
        {
            CreateMap<ReviewChapterModel, ReviewChapterDtoForUser>()
                .ForMember(destinationMember: destination => destination.ComicName,
                options => 
                {
                    options.MapFrom(mapExpression: source => source.ChapterModel.ComicModel.ComicName); 
                });
        }
    }
}