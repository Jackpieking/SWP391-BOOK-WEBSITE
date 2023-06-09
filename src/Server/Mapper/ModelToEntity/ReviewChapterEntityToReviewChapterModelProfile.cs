using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReviewChapterEntityToReviewChapterModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReviewChapterEntity => ReviewChapterModel
    /// </summary>
    public ReviewChapterEntityToReviewChapterModelProfile()
    {
        CreateMap<ReviewChapterEntity, ReviewChapterModel>()
        #region Member mapping
            //UserIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //ChapterIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterIdentifier);
                })
            //ChapterRatingStar
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterRatingStar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterRatingStar);
                })
            //ChapterComment
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterComment,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterComment);
                })
            //ReviewTime
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReviewTime,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewTime);
                })
            //UserModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ChapterModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                });
        #endregion
    }
}
