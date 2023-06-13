using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicSavingEntityAndComicSavingModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicSavingEntity => ComicSavingModel
    /// </summary>
    public ComicSavingEntityAndComicSavingModelProfile()
    {
        CreateMap<ComicSavingEntity, ComicSavingModel>()
        #region Member mapping
            //UserModel
            .ForMember(
                destinationMember: destination => destination.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ComicModel
            .ForMember(
                destinationMember: destination => destination.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })
        #endregion
        .ReverseMap();
    }
}
