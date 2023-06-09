using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicSavingEntityToComicSavingModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicSavingEntity => ComicSavingModel
    /// </summary>
    public ComicSavingEntityToComicSavingModelProfile()
    {
        CreateMap<ComicSavingEntity, ComicSavingModel>()
        #region Member mapping
            //UserIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //ComicIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicIdentifier);
                })
            //SavingTime
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.SavingTime,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.SavingTime);
                })
            //UserModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
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
