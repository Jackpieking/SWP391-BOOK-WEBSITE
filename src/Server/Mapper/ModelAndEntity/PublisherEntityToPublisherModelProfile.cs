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
            //UserModel
            .ForMember(
                destinationMember: publisherEntity => publisherEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ComicModels
            .ForMember(
                destinationMember: publisherEntity => publisherEntity.ComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntities);
                })
        #endregion
        .ReverseMap();
    }
}
