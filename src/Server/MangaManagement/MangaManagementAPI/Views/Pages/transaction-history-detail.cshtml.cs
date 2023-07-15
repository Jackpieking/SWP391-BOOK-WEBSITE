using AutoMapper;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class transaction_history_detailModel : PageModel
    {
        private readonly ILogger<UserManagementService> _logger;
        private readonly UserManagementService _userManagementService;
        private readonly IMapper _mapper;
        public IEnumerable<TransactionsHistoryModel> transactions;

        public transaction_history_detailModel(ILogger<UserManagementService> logger, UserManagementService userManagementService, IMapper mapper)
        {
            _logger = logger;
            _userManagementService = userManagementService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGet([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction To Get All Transaction history Of A User !!");

            try
            {
                transactions = await
                             _userManagementService
                            .GetTransactionsByUserIdAsync(userId);

                if (transactions == null)
                {
                    return RedirectToPage(pageName: "404");
                }

                return Page();
            }
            catch (TaskCanceledException TC_e)
            {
                _logger.LogError("[{DateTime.Now}] - Error: {TC_2.Message}", DateTime.Now, TC_e.Message);

                return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
            }
            catch (HttpRequestException HR_e)
            {
                _logger.LogError("[{DateTime.Now}] - Error: {HR_e.Message}", DateTime.Now, HR_e.Message);

                return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
            }
            finally
            {
                _logger.LogCritical(message: "Finished Transaction To Get All Transaction history Of A User !!");
            }
        }
    }
}
