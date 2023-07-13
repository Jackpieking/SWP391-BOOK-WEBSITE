using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class UserUpdate : PageModel
    {
        private readonly ILogger<UserUpdate> _logger;
        private readonly UserManagementService _userManagementService;
        private readonly IMapper _mapper;
        public UserUpdate(ILogger<UserUpdate> logger, UserManagementService userManagementService, IMapper mapper)
        {
            _mapper = mapper;
            _userManagementService = userManagementService;
            _logger = logger;
        }

        [BindProperty]
        public UserUpdateDto UserUpdateDto { get; set; }

        public async Task<IActionResult> OnGetGetInfo([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction To Show User Prepare For Update !!");

            var userNeedToUpdate = await
                _userManagementService
                .GetUserDetailsByIdAsync(userId);

            if (userNeedToUpdate == null)
            {
                return RedirectToPage(pageName: "404");
            }

            UserUpdateDto = _mapper.Map<UserUpdateDto>(source: userNeedToUpdate);

            _logger.LogCritical(message: "Start Transaction To Show User Prepare For Update !!");

            return Page();
        }

        public async Task<IActionResult> OnPostUpdateUser([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction To Update User !!");

            if (ModelState.IsValid)
            {
                UserUpdateDto.UserIdentifier = userId;

                // Update the user in the database
                await _userManagementService.UpdateUserAsync(user: _mapper.Map<UserModel>(source: UserUpdateDto));

                _logger.LogCritical(message: "Finish Transaction To Update User !!");

                return RedirectToPage(pageName: "user-details");
            }
            return RedirectToPage(pageName: "404");

        }
    }
}