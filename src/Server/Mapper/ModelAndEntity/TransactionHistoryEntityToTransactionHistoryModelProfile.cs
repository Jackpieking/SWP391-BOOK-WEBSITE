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
