using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class BuyingHistoryEntityToBuyingHistoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from BuyingHistoryEntity => BuyingHistoryModel
    /// </summary>
    public BuyingHistoryEntityToBuyingHistoryModelProfile()
    {
        CreateMap<BuyingHistoryEntity, BuyingHistoryModel>()
        #region Member mapping
            //UserIdentifer
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifer,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifer);
                })
            //ChapterIdentifer
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterIdentifer,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterIdentifer);
                })
            //BuyingDate
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.BuyingDate,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingDate);
                })
            //UserModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ChapterModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                });
        #endregion
    }
}
