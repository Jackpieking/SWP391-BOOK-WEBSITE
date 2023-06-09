using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ChapterImageEntityToChapterImageModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ChapterImageEntity => ChapterImageModel
    /// </summary>
    public ChapterImageEntityToChapterImageModelProfile()
    {
        CreateMap<ChapterImageEntity, ChapterImageModel>()
        #region Member mapping
            //ImageIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ImageIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ImageIdentifier);
                })
            //ImageNumber
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ImageNumber,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ImageNumber);
                })
            //ImageURL
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ImageURL,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ImageURL);
                })
            //ChapterIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterIdentifier);
                })
            //ChapterEntity
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                });
        #endregion
    }
}
