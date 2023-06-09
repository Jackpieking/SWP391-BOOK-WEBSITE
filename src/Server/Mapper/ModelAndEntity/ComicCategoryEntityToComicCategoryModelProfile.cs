using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicCategoryEntityToComicCategoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicCategoryEntity => ComicCategoryModel
    /// </summary>
    public ComicCategoryEntityToComicCategoryModelProfile()
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
