using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicCategoryEntityAndComicCategoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicCategoryEntity => ComicCategoryModel
    /// </summary>
    public ComicCategoryEntityAndComicCategoryModelProfile()
    {
        CreateMap<ComicCategoryEntity, ComicCategoryModel>()
        #region Member mapping
            //CategoryModel
            .ForMember(
                destinationMember: comicCategoryEntity => comicCategoryEntity.CategoryModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.CategoryEntity);
                })
            //ComicModel
            .ForMember(
                destinationMember: comicCategoryEntity => comicCategoryEntity.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })
        #endregion
        .ReverseMap();
    }
}
