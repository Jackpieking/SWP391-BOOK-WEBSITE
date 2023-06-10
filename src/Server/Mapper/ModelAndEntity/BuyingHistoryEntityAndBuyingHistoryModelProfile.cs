using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class BuyingHistoryEntityAndBuyingHistoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from BuyingHistoryEntity => BuyingHistoryModel
    /// </summary>
    public BuyingHistoryEntityAndBuyingHistoryModelProfile()
    {
        CreateMap<BuyingHistoryEntity, BuyingHistoryModel>()
        #region Member mapping
            //ChapterModel
            .ForMember(
                destinationMember: buyingHistoryEntity => buyingHistoryEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                });
        #endregion
    }
}
