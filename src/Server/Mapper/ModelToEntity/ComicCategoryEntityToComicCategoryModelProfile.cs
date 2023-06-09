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
            //CategoryIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.CategoryIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.CategoryIdentifier);
                })
            //ComicIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicIdentifier);
                })
            //CategoryModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.CategoryModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.CategoryEntity);
                })
            //ComicModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                });
        #endregion
    }
}
