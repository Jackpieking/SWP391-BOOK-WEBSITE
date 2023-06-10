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
                destinationMember: comicEntity => comicEntity.PublisherModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherEntity);
                })
            //ReviewComicModels
            .ForMember(
                destinationMember: comicEntity => comicEntity.ReviewComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewComicEntities);
                })
            //ComicSavingModels
            .ForMember(
                destinationMember: comicEntity => comicEntity.ComicSavingModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicSavingEntities);
                })
            //ChapterModels
            .ForMember(
                destinationMember: comicEntity => comicEntity.ChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntities);
                })
            //ComicCategoryModels
            .ForMember(
                destinationMember: comicEntity => comicEntity.ComicCategoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicCategoryEntities);
                })
        #endregion
        .ReverseMap();
    }
}
