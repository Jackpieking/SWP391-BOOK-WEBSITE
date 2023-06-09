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
            //CategoryIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.CategoryIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.CategoryIdentifier);
                })
            //CategoryName
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.CategoryName,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.CategoryName);
                })
            //CategoryDescription
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.CategoryDescription,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.CategoryDescription);
                })
            //ComicCategoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicCategoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicCategoryEntities);
                });
        #endregion
    }
}
