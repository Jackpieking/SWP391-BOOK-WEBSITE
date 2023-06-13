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
                destinationMember: destination => destination.PublisherModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.PublisherEntity);
                })
            //TransactionHistoryModels
            .ForMember(
                destinationMember: destination => destination.TransactionsHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.TransactionHistoryEntities);
                })
            //ComicSavingModels
            .ForMember(
                destinationMember: destination => destination.ComicSavingModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicSavingEntities);
                })
            //ReadingHistoryModels
            .ForMember(
                destinationMember: destination => destination.ReadingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReadingHistorieEntities);
                })
            //ReviewComicModels
            .ForMember(
                destinationMember: destination => destination.ReviewComicModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewComicEntities);
                })
            //ReviewChapterModels
            .ForMember(
                destinationMember: destination => destination.ReviewChapterModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewChapterEntities);
                })
            //BuyingHistoryModels
            .ForMember(
                destinationMember: destination => destination.BuyingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingHistorieEntities);
                })
            //ComicLikeModels
            .ForMember(
                destinationMember: destination => destination.ComicLikeModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicLikeEntities);
                })
        #endregion
        .ReverseMap();
    }
}
