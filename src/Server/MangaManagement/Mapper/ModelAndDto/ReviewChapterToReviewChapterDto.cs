using AutoMapper;
using DTO.Incoming;
using Model;

namespace Mapper.ModelAndDto
{
    public class ReviewChapterToReviewChapterDto : Profile
    {
        public ReviewChapterToReviewChapterDto()
        {
            CreateMap<ReviewChapterModel, ReviewChapterDto>()
                .ForMember(destinationMember: destination => destination.ChapterNumber,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.ChapterModel.ChapterNumber);
                })
                .ForMember(destinationMember: destination => destination.Username, 
                options =>
                {
                    options.MapFrom(mapExpression: source => source.UserModel.Username);
                })
                .ForMember(destinationMember: destination => destination.ComicName,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.ChapterModel.ComicModel.ComicName);
                })
                .ReverseMap();
        }
    }
}