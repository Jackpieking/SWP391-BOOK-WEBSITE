using AutoMapper;
using DTO.Incoming;
using Model;

namespace Mapper.ModelAndDto
{
    public class TransactionHistoryModelToTransactionHistoryDto : Profile
    {
        public TransactionHistoryModelToTransactionHistoryDto()
        {
            CreateMap<TransactionsHistoryModel, TransactionHistoryDto>();
        }
    }
}