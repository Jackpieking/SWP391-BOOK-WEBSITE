using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class TransactionHistoryEntityAndTransactionHistoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from TransactionHistoryEntity => TransactionHistoryModel
    /// </summary>
    public TransactionHistoryEntityAndTransactionHistoryModelProfile()
    {
        CreateMap<TransactionsHistoryEntity, TransactionsHistoryModel>()
        #region Member mapping
            //UserModel
            .ForMember(
                destinationMember: transactionsHistoryEntity => transactionsHistoryEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
        #endregion
        .ReverseMap();
    }
}
