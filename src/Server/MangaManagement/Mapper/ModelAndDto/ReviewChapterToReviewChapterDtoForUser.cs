using AutoMapper;

namespace Mapper.ModelAndDto
{
    public class ReviewChapterToReviewChapterDtoForUser : Profile
    {
        //public ReviewChapterToReviewChapterDtoForUser()
        //{
        //    CreateMap<ReviewChapterModel, ReviewChapterDtoForUser>()
        //        .ForMember(destinationMember: destination => destination.ComicName,
        //        options =>
        //        {
        //            options.MapFrom(mapExpression: source => source.ChapterModel.ComicModel.ComicName);
        //        })

        //        .ForMember(destinationMember: destination => destination.ChapterNumber,
        //        options =>
        //        {
        //            options.MapFrom(mapExpression: source => source.ChapterModel.ChapterNumber);
        //        })
        //        ;
        //}
    }
}