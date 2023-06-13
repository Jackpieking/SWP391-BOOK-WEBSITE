using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class PublisherEntityAndPublisherModelProfile : Profile
{
    /// <summary>
    /// Map configuration from PublisherEntity => PublisherModel
    /// </summary>
    public PublisherEntityAndPublisherModelProfile()
    {
        CreateMap<PublisherEntity, PublisherModel>()
        #region Member mapping
            //UserModel
            .ForMember(
                destinationMember: destination => destination.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ComicModels
            .ForMember(
                destinationMember: destination => destination.ComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntities);
                })
        #endregion
        .ReverseMap();
    }
}
