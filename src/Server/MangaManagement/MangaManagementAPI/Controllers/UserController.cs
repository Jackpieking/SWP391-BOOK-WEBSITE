using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Outgoing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Helper;
using Npgsql;
using Microsoft.AspNetCore.Http;

namespace MangaManagementAPI.Controllers
{
 
    [Route(template: "admin/users/[action]/{id?}")]
    public class UserController : Controller
    {
        private readonly UserManagementService _userManagementService;
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;

        public UserController(UserManagementService userManagementService, ILogger<UserController> logger, IMapper mapper)
        {
            _userManagementService = userManagementService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserAsync()
        {
            _logger.LogCritical(message: "Start Transaction Get All User !!");

            try

            {
                var userModels = await _userManagementService.GetAllUserAsync();
                ICollection<GetAllUserAction_Out_Dto> getAllUserDtoList = new List<GetAllUserAction_Out_Dto>();

                userModels.ForEach(action: userModel =>
                {
                    var getAllUserDto = _mapper.Map<GetAllUserAction_Out_Dto>(source: userModel);
                    getAllUserDtoList.Add(item: getAllUserDto);
                });

                ViewBag.getAllUserDtoList = getAllUserDtoList;

                return View(getAllUserDtoList);
            }

            catch (NpgsqlException N_e)

            {
                _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

                return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
            }

            finally

            {
                _logger.LogCritical(message: "End Transaction Get All User !!");
            }
        }

        //  [HttpGet(template: "{userid:guid}")]
        //  public async Task<IActionResult> GetUserDetailsByIdAsync([FromRoute] Guid id)
        //  {
        //     _logger.LogCritical(message: "Start Transaction Get A User Details!!");

        //     try

        //     {
        //         var userModel = await _userManagementService.GetUserDetailsByIdAsync(userId: id);

        //         GetAllUserDetailsAction_Out_Dto userDto = new GetAllUserDetailsAction_Out_Dto() 
        //         {
                        
        //         };    
        //     }
        //  }


    }
}