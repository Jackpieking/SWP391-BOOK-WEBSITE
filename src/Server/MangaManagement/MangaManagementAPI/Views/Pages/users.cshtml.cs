using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model;
using AutoMapper;
using DTO.Outgoing;
using Npgsql;
using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace MangaManagementAPI.Views.Pages
{
    public class UsersModel : PageModel
    {
        private readonly ILogger<UsersModel> _logger;
        private readonly UserManagementService _userManagementService;
        private readonly IMapper _mapper;


        public IEnumerable<GetAllUserAction_Out_Dto> UserList { get; set; }

        public UsersModel(ILogger<UsersModel> logger, UserManagementService userManagementService, IMapper mapper)
        {
            _logger = logger;
            _userManagementService = userManagementService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGet()
        {
            _logger.LogCritical(message: "Start Transaction To Get All Users !!");

            try
            {
                var users = await _userManagementService.GetAllUserAsync();
                UserList = _mapper.Map<IEnumerable<GetAllUserAction_Out_Dto>>(users);
                return Page();
            }

            catch (NpgsqlException N_e)

            {
                _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

                return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
            }

            finally

            {
                _logger.LogCritical(message: "End Transaction To Get All Users !!");
            }

        }

    }
}