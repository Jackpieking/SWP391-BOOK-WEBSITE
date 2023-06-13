using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ChapterEntityAndChapterModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ChapterEntity => ChapterModel
    /// </summary>
    public ChapterEntityAndChapterModelProfile()
    {
        CreateMap<ChapterEntity, ChapterModel>()
        #region Member mapping
            //ComicModels
            .ForMember(
                destinationMember: destination => destination.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })

            //ReviewChapterModels
            .ForMember(
                destinationMember: destination => destination.ReviewChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewChapterEntities);
                })
            //ReadingHistoryModels
            .ForMember(
                destinationMember: destination => destination.ReadingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReadingHistoryEntities);
                })
            //ChapterImageModels
            .ForMember(
                destinationMember: destination => destination.ChapterImageModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterImageEntities);
                })
            //BuyingHistoryModels
            .ForMember(
                destinationMember: destination => destination.BuyingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingHistoryEntities);
                })
        #endregion
        .ReverseMap();
    }
}
