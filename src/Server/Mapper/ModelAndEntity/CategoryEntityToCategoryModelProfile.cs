using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class CategoryEntityToCategoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from CategoryEntity => CategoryModel
    /// </summary>
    public CategoryEntityToCategoryModelProfile()
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
