using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReviewComicEntityToReviewComicModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReviewComicEntity => ReviewComicModel
    /// </summary>
    public ReviewComicEntityToReviewComicModelProfile()
    {
        CreateMap<ReviewComicEntity, ReviewComicModel>()
        #region Member mapping
            //ComicModel
            .ForMember(
                destinationMember: reviewComicEntity => reviewComicEntity.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })
        #endregion
        .ReverseMap();
    }
}
