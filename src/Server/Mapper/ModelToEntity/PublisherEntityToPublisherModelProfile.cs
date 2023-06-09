using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class PublisherEntityToPublisherModelProfile : Profile
{
    /// <summary>
    /// Map configuration from PublisherEntity => PublisherModel
    /// </summary>
    public PublisherEntityToPublisherModelProfile()
    {
        CreateMap<PublisherEntity, PublisherModel>()
        #region Member mapping
            //PublisherIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.PublisherIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherIdentifier);
                })
            //UserIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //PublisherDescription
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.PublisherDescription,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherDescription);
                })
            //UserModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ComicModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntities);
                });
        #endregion
    }
}
