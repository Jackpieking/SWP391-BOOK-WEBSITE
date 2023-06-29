using System;
using Helper;
using System.Threading.Tasks;
using BusinessLogicLayer.Services;
using DTO.Outgoing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Helper.DefinedEnums;
using AutoMapper;
using Entity;
using Model;

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

        public new GetAllUserAction_Out_Dto User { get; set; }

        public async Task<IActionResult> OnGetGetInfo([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction To Show User Prepare For Update !!");

            var userNeedToUpdate = await
                _userManagementService
                .GetUserDetailsByIdAsync(userId);

            User = _mapper.Map<GetAllUserAction_Out_Dto>(source: userNeedToUpdate);

            _logger.LogCritical(message: "Start Transaction To Show User Prepare For Update !!");

            return Page();
        }

        public async Task<IActionResult> OnPostUpdateUser([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction To Update User !!");
            

            if (ModelState.IsValid)
            {
                string username = Request.Form["Username"];
                string userFullName = Request.Form["UserFullName"];
                string userGender = Request.Form["UserGender"];
                DateOnly userBirthday = DateOnly.Parse(Request.Form["UserBirthday"]);

                // Create a new User object with the updated values
                var updatedUser = new GetAllUserAction_Out_Dto
                {
                    UserIdentifier = userId, 
                    UserFullName = userFullName,
                    Username = username,
                    UserGender = Enum.TryParse(userGender, ignoreCase: true, out DefinedGender result) ? result : DefinedGender.OTHERS,
                    UserBirthday = userBirthday
                };

                // Update the user in the database
                await _userManagementService.UpdateUserAsync(_mapper.Map<UserModel>(updatedUser));

                _logger.LogCritical(message: "Finish Transaction To Update User !!");

                return RedirectToPage(pageName: "user-details");
            }
            return RedirectToPage(pageName: "404");

        }
    }
}