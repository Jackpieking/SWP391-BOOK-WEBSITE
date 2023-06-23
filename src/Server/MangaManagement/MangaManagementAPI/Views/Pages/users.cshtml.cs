using Helper;
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

        public async Task OnGet()
        {
            var users = await _userManagementService.GetAllUserAsync();
            UserList = _mapper.Map<IEnumerable<GetAllUserAction_Out_Dto>>(users);

        }

    }
}