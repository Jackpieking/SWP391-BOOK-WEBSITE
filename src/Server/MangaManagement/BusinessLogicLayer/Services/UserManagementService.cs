using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Entity;
using Microsoft.Extensions.Logging;
using Model;

namespace BusinessLogicLayer.Services
{
    public class UserManagementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UserManagementService> _logger;

        public UserManagementService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UserManagementService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        /// <summary>
        /// Get all users without any reference from database
        /// </summary>
        /// <returns>Task<IEnumerable<UserModel></UserModel>></returns>
        public async Task<IEnumerable<UserModel>> GetAllUserAsync()
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On User Table", args: DateTime.Now);

            var userEntities = await
                _unitOfWork
                .UserInfoRepository
                .GetUsersAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On User Table", args: DateTime.Now);
            return _mapper.Map<IEnumerable<UserModel>>(userEntities);
        }


        /// <summary>
        /// Get a user details by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<UserModel></returns>
        public async Task<UserModel> GetUserDetailsByIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On User Table", args: DateTime.Now);

            var userEntity = await
            _unitOfWork
            .UserInfoRepository
            .GetUserDetailsByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On User Table", args: DateTime.Now);
            return _mapper.Map<UserModel>(userEntity);
        }


        /// <summary>
        /// Get all user's transactions history by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<TransactionsHistoryModel>></returns>
        public async Task<ICollection<TransactionsHistoryModel>> GetAllTransactionsOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Transaction History Table", args: DateTime.Now);

            var transactionHistoryEntities = await
                _unitOfWork
                .TransactionRepository
                .GetTransactionHistoriesWith_TransactionAmount_TransactionDate_TransactionCointByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Transaction History Table", args: DateTime.Now);
            return _mapper.Map<ICollection<TransactionsHistoryModel>>(transactionHistoryEntities);
        }


        /// <summary>
        /// Get all user's reviews on comic by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<ReviewComicModel>></returns>
        public async Task<ICollection<ReviewComicModel>> GetAllReviewsOnComicOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Review Table", args: DateTime.Now);

            var reviewComicEntities = await
                _unitOfWork
                .ReviewComicRepository
                .GetComicReviewsByUserId(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Review Table", args: DateTime.Now);
            return _mapper.Map<ICollection<ReviewComicModel>>(reviewComicEntities);
        }


        /// <summary>
        /// Get all user's reviews on chapter by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<ReviewChapterModel>></returns>
        public async Task<ICollection<ReviewChapterModel>> GetAllReviewOnChapterOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Chapter Review Table", args: DateTime.Now);

            var reviewChapterEntites = await
                _unitOfWork
                .ReviewChapterRepository
                .GetChapterReviewsWith_ChapterNumber_ComicName_ChapterComment_ChapterRatingStar_ReviewTimeByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Chapter Review Table", args: DateTime.Now);

            return _mapper.Map<ICollection<ReviewChapterModel>>(reviewChapterEntites);

        }


        /// <summary>
        /// Get all user's buying history on chapter by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<BuyingHistoryModel>></returns>
        public async Task<ICollection<BuyingHistoryModel>> GetAllBuyingHistoryOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Buying History Table", args: DateTime.Now);

            var buyingHistoryEntities = await
                _unitOfWork
                .BuyingHistoryRepository
                .GetBuyingHistoriesByUserId(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Buying History Table", args: DateTime.Now);
            return _mapper.Map<ICollection<BuyingHistoryModel>>(buyingHistoryEntities);
        }


        /// <summary>
        /// Get all user's comic saving by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<ComicSavingModel>></returns>
        public async Task<ICollection<ComicSavingModel>> GetAllComicSavingOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Saving Table", args: DateTime.Now);

            var comicSavingEntities = await
                _unitOfWork
                .ComicSavingRepository
                .GetComicSavingsByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Saving Table", args: DateTime.Now);
            return _mapper.Map<ICollection<ComicSavingModel>>(comicSavingEntities);
        }


        /// <summary>
        /// Get all user's reading history by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<ReadingHistoryModel>></returns>
        public async Task<ICollection<ReadingHistoryModel>> GetAllReadingHistoryOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Saving Table", args: DateTime.Now);

            var readingHistoryEntities = await
                _unitOfWork
                .ReadingHistoryRepository
                .GetReadingHistoresWith_LastReadingTime_ChapterNumber_ComicNameByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Saving Table", args: DateTime.Now);
            return _mapper.Map<ICollection<ReadingHistoryModel>>(readingHistoryEntities);
        }


        /// <summary>
        /// Get all user's comic likes by userIndetifier reference from database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<ComicLikeModel>></returns>
        public async Task<ICollection<ComicLikeModel>> GetAllComicLikeOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Like Table", args: DateTime.Now);

            var comicLikeEntities = await
                _unitOfWork
                .ComicLikeRepository
                .GetComicLikesByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Like Table", args: DateTime.Now);
            return _mapper.Map<ICollection<ComicLikeModel>>(comicLikeEntities);
        }

        public async Task DeleteUserByIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Delete User", args: DateTime.Now);

            await _unitOfWork
                .UserInfoRepository
                .DeleteUserByUserIdAsync(userId);

            await _unitOfWork
                .SaveAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Delete User", args: DateTime.Now);
        }
    }
}