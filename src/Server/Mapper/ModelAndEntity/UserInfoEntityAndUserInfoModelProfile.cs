using AutoMapper;
using Entity;
using Model;

namespace Helper.ObjectMappers.ModelToEntity;

public class UserInfoEntityAndUserInfoModelProfile : Profile
{
    /// <summary>
    /// Map configuration from UserInfoEntity => UserInfoModel
    /// </summary>
    public UserInfoEntityAndUserInfoModelProfile()
    {
        CreateMap<UserEntity, UserModel>()
        #region Member mapping
            //PublisherModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.PublisherModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherEntity);
                })
            //TransactionHistoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.TransactionsHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.TransactionHistoryEntities);
                })
            //ComicSavingModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ComicSavingModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicSavingEntities);
                })
            //ReadingHistoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReadingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReadingHistorieEntities);
                })
            //ReviewComicModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReviewComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewComicEntities);
                })
            //ReviewChapterModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ReviewChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewChapterEntities);
                })
            //BuyingHistoryModels
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.BuyingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingHistorieEntities);
                })
        #endregion
        .ReverseMap();
    }
}
