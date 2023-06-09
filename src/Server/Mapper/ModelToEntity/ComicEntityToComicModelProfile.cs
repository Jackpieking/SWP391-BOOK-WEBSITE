using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicEntityToComicModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicEntity => ComicModel
    /// </summary>
    public ComicEntityToComicModelProfile()
    {
        CreateMap<ComicEntity, ComicModel>()
        #region Member mapping
            //ComicIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicIdentifier);
                })
            //PublisherIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.PublisherIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherIdentifier);
                })
            //ComicName
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicName,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicName);
                })
            //ComicDescription
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicDescription,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicDescription);
                })
            //ComicAvatar
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicAvatar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicAvatar);
                })
            //ComicPublishDate
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicPublishDate,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicPublishDate);
                })
            //ComicLastestChapter
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicLatestChapter,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicLatestChapter);
                })
            //PublisherModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.PublisherModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherEntity);
                })
            //ReviewComicModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReviewComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewComicEntities);
                })
            //ComicSavingModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicSavingModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicSavingEntities);
                })
            //ChapterModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntities);
                })
            //ComicCategoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicCategoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicCategoryEntities);
                });
        #endregion
    }
}
