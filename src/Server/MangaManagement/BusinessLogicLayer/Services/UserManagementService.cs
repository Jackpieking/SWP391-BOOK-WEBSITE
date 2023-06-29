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
                .GetAllUserAsync();

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
            .GetUserDetailsById(userId);

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
                .GetTransactionHistoriesOfAUserByUserId(userId);

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
                .GetComicReviewsOfAUserByUserId(userId);

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
                .GetChapterReviewsOfAUserByUserId(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Chapter Review Table", args: DateTime.Now);

            return _mapper.Map<ICollection<ReviewChapterModel>>(reviewChapterEntites);

        }

        /// <summary>
        /// Get A Publisher Model of a user by user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<PublisherModel></returns>
        public async Task<PublisherModel> GetPublisherModelOfAUserByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Publisher Table", args: DateTime.Now);

            var publisherEntity = await
            _unitOfWork
            .PublisherRepository
            .GetPublisherInfoByUserIdAsync(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Publisher Table", args: DateTime.Now);

            return _mapper.Map<PublisherModel>(publisherEntity);
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
                .GetBuyingHistoriesOfAUserByUserId(userId);

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
                .GetComicSavingsOfAUserByUserId(userId);

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
                .GetAllReadingHistoresOfAUserByUserId(userId);

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
                .GetComicLikesOfAUserByUserId(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Like Table", args: DateTime.Now);
            return _mapper.Map<ICollection<ComicLikeModel>>(comicLikeEntities);
        }

        public async Task DeleteUserByIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Delete User", args: DateTime.Now);

            await _unitOfWork
                .UserInfoRepository
                .DeleteUserByIdAsync(userId);

            await _unitOfWork
                .SaveAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Delete User", args: DateTime.Now);
        }

        
        public async Task UpdateUserAsync(UserModel user)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Update User", args: DateTime.Now);

            await _unitOfWork
                .UserInfoRepository
                .UpdateUserAsync(_mapper.Map<UserEntity>(user));

            await _unitOfWork
                .SaveAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Start Update User", args: DateTime.Now);
        }

    
    }
}