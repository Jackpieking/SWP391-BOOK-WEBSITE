using AutoMapper;
using Entity;
using Model;

namespace Helper.ObjectMappers.ModelToEntity;

public class UserInfoEntityToUserInfoModelProfile : Profile
{
    /// <summary>
    /// Map configuration from UserInfoEntity => UserInfoModel
    /// </summary>
    public UserInfoEntityToUserInfoModelProfile()
    {
        CreateMap<UserEntity, UserModel>()
        #region Member mapping
            //UserIdentifer
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //Username
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserName,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.Username);
                })
            //Password
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.Password,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.Password);
                })
            //UserFullName
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserFullName,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserFullName);
                })
            //UserGender
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserGender,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserGender);
                })
            //UserBirthday
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserBirthday,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserBirthday);
                })
            //UserPhoneNumber
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserPhoneNumber,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserPhoneNumber);
                })
            //UserEmail
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserEmail,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEmail);
                })
            //UserAccountBalance
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserAccountBalance,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserAccountBalance);
                })
            //UserAvatar
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserAvatar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserAvatar);
                })
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
            //BuyingHistory
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.BuyingHistoryModels,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.BuyingHistorieEntities);
                });
        #endregion
    }
}
