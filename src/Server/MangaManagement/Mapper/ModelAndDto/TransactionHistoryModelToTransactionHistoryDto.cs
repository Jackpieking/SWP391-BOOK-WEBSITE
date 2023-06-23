using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Model;
using static DTO.Outgoing.GetAllUserDetailsAction_Out_Dto;

namespace Mapper.ModelAndDto
{
    public class TransactionHistoryModelToTransactionHistoryDto : Profile
    {
        public TransactionHistoryModelToTransactionHistoryDto()
        {
            CreateMap<TransactionsHistoryModel, TransactionsHistoryDto>();
        }
    }
}