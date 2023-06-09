using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReviewComicEntityToReviewComicModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReviewComicEntity => ReviewComicModel
    /// </summary>
    public ReviewComicEntityToReviewComicModelProfile()
    {
        CreateMap<ReviewComicEntity, ReviewComicModel>()
        #region Member mapping
            //UserIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //ComicIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicIdentifier);
                })
            //ComicRatingStar
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicRatingStar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicRatingStar);
                })
            //ComicComment
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicComment,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicComment);
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
            //ComicModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                });
        #endregion
    }
}
