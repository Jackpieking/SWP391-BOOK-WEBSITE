using AutoMapper;
using Entity;

namespace Mapper.ModelAndEntity;

public class ComicLikeEntityAndComicLikeModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicLikeEntity => ComicLikeModel
    /// </summary>
    public ComicLikeEntityAndComicLikeModelProfile()
    {
        CreateMap<ComicLikeEntity, ComicLikeModel>()
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
