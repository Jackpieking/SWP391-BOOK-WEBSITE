using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ChapterEntityToChapterModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ChapterEntity => ChapterModel
    /// </summary>
    public ChapterEntityToChapterModelProfile()
    {
        CreateMap<ChapterEntity, ChapterModel>()
        #region Member mapping
            //ChapterIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterIdentifier);
                })
            //ChapterNumber
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterNumber,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterNumber);
                })
            //ChapterUnlockPrice
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterUnlockPrice,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterUnlockPrice);
                })
            //ComicIdentifer
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicIdentifier);
                })
            //ReviewChapterModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReviewChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewChapterEntities);
                })
            //ReadingHistoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReadingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReadingHistoryEntities);
                })
            //ChapterImageModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterImageModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterImageEntities);
                })
            //BuyingHistoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.BuyingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingHistoryEntities);
                });
        #endregion
    }
}
