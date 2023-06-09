using AutoMapper;
using Entity;
using Microsoft.Extensions.Options;
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
            //ChapterModels
            .ForMember(
                destinationMember: chapterEntity => chapterEntity.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })

            //ReviewChapterModels
            .ForMember(
                destinationMember: chapterEntity => chapterEntity.ReviewChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewChapterEntities);
                })
            //ReadingHistoryModels
            .ForMember(
                destinationMember: chapterEntity => chapterEntity.ReadingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReadingHistoryEntities);
                })
            //ChapterImageModels
            .ForMember(
                destinationMember: chapterEntity => chapterEntity.ChapterImageModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterImageEntities);
                })
            //BuyingHistoryModels
            .ForMember(
                destinationMember: chapterEntity => chapterEntity.BuyingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingHistoryEntities);
                })
        #endregion
        .ReverseMap();
    }
}
