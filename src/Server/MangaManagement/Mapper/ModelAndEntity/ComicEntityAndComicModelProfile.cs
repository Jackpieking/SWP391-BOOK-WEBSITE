using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicEntityAndComicModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicEntity => ComicModel
    /// </summary>
    public ComicEntityAndComicModelProfile()
    {
        CreateMap<ComicEntity, ComicModel>()
        #region Member mapping
            //PublisherModel
            .ForMember(
                destinationMember: destination => destination.PublisherModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherEntity);
                })
            //ReviewComicModels
            .ForMember(
                destinationMember: destination => destination.ReviewComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewComicEntities);
                })
            //ComicSavingModels
            .ForMember(
                destinationMember: destination => destination.ComicSavingModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicSavingEntities);
                })
            //ChapterModels
            .ForMember(
                destinationMember: destination => destination.ChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntities);
                })
            //ComicCategoryModels
            .ForMember(
                destinationMember: destination => destination.ComicCategoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicCategoryEntities);
                })
            //ComicLikeModels
            .ForMember(
                destinationMember: destination => destination.ComicLikeModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicLikeEntities);
                })
        #endregion
        .ReverseMap();
    }
}
