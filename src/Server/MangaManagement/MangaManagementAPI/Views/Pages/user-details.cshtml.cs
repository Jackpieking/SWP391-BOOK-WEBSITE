using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Outgoing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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
                .GetUserDetailsByIdAsync(userId);

                var readingHistoryModels = await _userManagementService
                .GetAllReadingHistoryOfAUserByUserIdAsync(userId);

                var transactionsHistoryModel = await _userManagementService
                .GetAllTransactionsOfAUserByUserIdAsync(userId);

                var buyingHistoryModel = await _userManagementService
                .GetAllBuyingHistoryOfAUserByUserIdAsync(userId);

                var comicLikeModel = await _userManagementService
                .GetAllComicLikeOfAUserByUserIdAsync(userId);

                var reviewComicModel = await _userManagementService
                .GetAllReviewsOnComicOfAUserByUserIdAsync(userId);

                var reviewChapterModel = await _userManagementService
                .GetAllReviewOnChapterOfAUserByUserIdAsync(userId);

                var comicSavingModel = await _userManagementService
                .GetAllComicSavingOfAUserByUserIdAsync(userId);

                GetAllUserDetailsAction_Out_Dto userDetailsDto = new()
                {
                    UserBasicInfo = _mapper.Map<GetAllUserAction_Out_Dto>(userModel),
                    ReadingHistoriesOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.ReadingHistoryDto>>(readingHistoryModels),
                    BuyingHistorieOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.BuyingHistoryDto>>(buyingHistoryModel),
                    ReviewChapterOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.ReviewChapterDtoForUser>>(reviewChapterModel),
                    ReviewComicOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.ReviewComicDtoForUser>>(reviewComicModel),
                    TransactionHistoryOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.TransactionsHistoryDto>>(transactionsHistoryModel),
                    ComicLikeOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.ComicLikeDto>>(comicLikeModel),
                    ComicSavingOutDto = _mapper.Map<ICollection<GetAllUserDetailsAction_Out_Dto.ComicSavingDto>>(comicSavingModel)
                };
                _logger.LogCritical(message: "End Transaction Get User Detail !!");

                UserDetails = userDetailsDto;

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
        }
    }
}