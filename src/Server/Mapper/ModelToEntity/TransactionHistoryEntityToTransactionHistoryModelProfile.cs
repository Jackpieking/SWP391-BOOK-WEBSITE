using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class TransactionHistoryEntityToTransactionHistoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from TransactionHistoryEntity => TransactionHistoryModel
    /// </summary>
    public TransactionHistoryEntityToTransactionHistoryModelProfile()
    {
        CreateMap<TransactionsHistoryEntity, TransactionsHistoryModel>()
        #region Member mapping
            //TransactionIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.TransactionIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.TransactionIdentifier);
                })
            //TransactionAmount
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.TransactionAmount,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.TransactionAmount);
                })
            //TransactionCoin
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.TransactionCoin,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.TransactionCoin);
                })
            //TransactionDate
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.TransactionDate,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.TransactionDate);
                })
            //UserIdentifer
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //UserModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                });
        #endregion
    }
}
