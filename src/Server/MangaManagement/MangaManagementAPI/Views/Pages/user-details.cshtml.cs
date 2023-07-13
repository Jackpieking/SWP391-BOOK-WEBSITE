using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using DTO.Outgoing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MangaManagementAPI.Views.Pages
{
    public class UserDetailsModel : PageModel
    {
        private readonly ILogger<UserDetailsModel> _logger;
        private readonly UserManagementService _userManagementService;
        private readonly IMapper _mapper;

        public GetAllUserDetailsAction_Out_Dto UserDetails { get; set; }

        public UserDetailsModel(ILogger<UserDetailsModel> logger, UserManagementService userManagementService, IMapper mapper)
        {
            _logger = logger;
            _userManagementService = userManagementService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetUserDetails([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction Get User Detail !!");

            try
            {
                var userModel = await _userManagementService
                    .GetUserDetailsByIdAsync(userId: userId);

                if (userModel == null)
                {
                    return RedirectToPage(pageName: "404");
                }

                //var readingHistoryModels = await _userManagementService
                //.GetAllReadingHistoryOfAUserByUserIdAsync(userId);

                //var transactionsHistoryModel = await _userManagementService
                //.GetAllTransactionsOfAUserByUserIdAsync(userId);

                //var buyingHistoryModel = await _userManagementService
                //.GetAllBuyingHistoryOfAUserByUserIdAsync(userId);

                //var comicLikeModel = await _userManagementService
                //.GetAllComicLikeOfAUserByUserIdAsync(userId);

                //var reviewComicModel = await _userManagementService
                //.GetAllReviewsOnComicOfAUserByUserIdAsync(userId);

                //var reviewChapterModel = await _userManagementService
                //.GetAllReviewOnChapterOfAUserByUserIdAsync(userId);

                //var comicSavingModel = await _userManagementService
                //.GetAllComicSavingOfAUserByUserIdAsync(userId);

                UserDetails = new()
                {
                    UserBasicInfo = _mapper.Map<UserUpdateDto>(source: userModel),
                };

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
                _logger.LogCritical(message: "End Transaction Get User Detail !!");
            }
        }

        public async Task<IActionResult> OnGetDeleteUser([FromRoute] Guid userId)
        {
            _logger.LogCritical(message: "Start Transaction To Delete User !!");

            try
            {
                await _userManagementService.DeleteUserByIdAsync(userId);
                return RedirectToPage("users");
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
                _logger.LogCritical(message: "Finished Transaction To Delete User !!");
            }
        }

        public async Task<IActionResult> OnGetComicDelete([FromRoute] Guid userId, [FromQuery] Guid comicId)
        {
            _logger.LogCritical(message: "Start Transaction To Delete Reviewed On Comic Of A User !!");

            try
            {
                await _userManagementService.DeleteUserReviewedComicByIdAsync(userId, comicId);
                return RedirectToPage(pageName: "user-details", pageHandler: "UserDetails", routeValues: new { userId });
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
                _logger.LogCritical(message: "Finished Transaction To Delete Reviewed On Comic Of A User !!");
            }
        }

        public async Task<IActionResult> OnGetChapterDelete([FromRoute] Guid userId, [FromQuery] Guid chapterId)
        {
            _logger.LogCritical(message: "Start Transaction To Delete Reviewed On Chapter Of A User !!");

            try
            {
                await _userManagementService.DeleteUserReviewedChapterByIdAsync(userId, chapterId);
                return RedirectToPage(pageName: "user-details", pageHandler: "UserDetails", routeValues: new { userId });
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
                _logger.LogCritical(message: "Finished Transaction To Delete Reviewed On Chapter Of A User !!");
            }
        }
    }
}