using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class CategoryEntityAndCategoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from CategoryEntity => CategoryModel
    /// </summary>
    public CategoryEntityAndCategoryModelProfile()
    {
        CreateMap<CategoryEntity, CategoryModel>()
        #region Member mapping
            //ComicCategoryModels
            .ForMember(
                destinationMember: categoryEntity => categoryEntity.ComicCategoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicCategoryEntities);
                })
        #endregion
        .ReverseMap();
    }
}
