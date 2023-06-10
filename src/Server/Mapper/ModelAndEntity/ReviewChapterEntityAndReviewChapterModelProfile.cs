using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReviewChapterEntityAndReviewChapterModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReviewChapterEntity => ReviewChapterModel
    /// </summary>
    public ReviewChapterEntityAndReviewChapterModelProfile()
    {
        CreateMap<ReviewChapterEntity, ReviewChapterModel>()
        #region Member mapping
            //UserModel
            .ForMember(
                destinationMember: reviewChapterEntity => reviewChapterEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ChapterModel
            .ForMember(
                destinationMember: reviewChapterEntity => reviewChapterEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                })
        #endregion
        .ReverseMap();
    }
}
