using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class user_transaction_historyModel : PageModel
    {
        private readonly ILogger<user_transaction_historyModel> _logger;
        private readonly EntityManagementService _entityManagementService;
        private readonly IMapper _mapper;


        public IDictionary<Guid, IList<TransactionHistoryDto>> UserTransactionHistory { get; set; }

        public user_transaction_historyModel(ILogger<user_transaction_historyModel> logger, EntityManagementService entityManagementService, IMapper mapper)
        {
            _logger = logger;
            _entityManagementService = entityManagementService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var transactionHistoryModels = await _entityManagementService.GetAllTransactionHistoryAsync();

            UserTransactionHistory = new Dictionary<Guid, IList<TransactionHistoryDto>>();

            foreach (var transactionHistoryModel in transactionHistoryModels)
            {
                UserTransactionHistory.Add(transactionHistoryModel.Key, _mapper.Map<IList<TransactionHistoryDto>>(transactionHistoryModel.Value));

                for (int idx = 0; idx < transactionHistoryModel.Value.Count; idx++)
                {
                    var tran = UserTransactionHistory[transactionHistoryModel.Key][idx];
                    var anotherTran = transactionHistoryModel.Value[idx];

                    tran.Username = anotherTran.UserModel.Username;
                }
            }

            return Page();
        }
    }
}
