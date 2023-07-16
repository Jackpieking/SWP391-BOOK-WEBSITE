using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Entity;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<UserModel>> GetAllUserHaveLikeAsync()
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On User Table", args: DateTime.Now);

            var userEntities = await
                _unitOfWork
                .UserInfoRepository
                .GetAllUserHaveLikeAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On User Table", args: DateTime.Now);
            return _mapper.Map<IEnumerable<UserModel>>(userEntities);
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
        public async Task<ICollection<TransactionsHistoryModel>> GetTransactionsByUserIdAsync(Guid userId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Transaction History Table", args: DateTime.Now);

            var transactionHistoryEntities = await
                _unitOfWork
                .TransactionRepository
                .GetTransactionsByUserId(userId);

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
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

            var readingHistoryEntities = await
                _unitOfWork
                .ReadingHistoryRepository
                .GetAllReadingHistoresOfAUserByUserId(userId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Reading History Table", args: DateTime.Now);
            return _mapper.Map<ICollection<ReadingHistoryModel>>(readingHistoryEntities);
        }

        /// <summary>
        /// Delete user by userId and save changes into the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task</returns>
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


        /// <summary>
        /// Udpate basic infos of a user by admin by user Id
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task</returns>
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


        /// <summary>
        /// Delete Reviewed comic of a user by userId and comicId, and save changes into the database
        /// (If the reviewed content is not approriate)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="comicId"></param>
        /// <returns>Task</returns>
        public async Task DeleteUserReviewedComicByIdAsync(Guid userId, Guid comicId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Delete Reviewed On Comic Of A User", args: DateTime.Now);

            await _unitOfWork
                .ReviewComicRepository
                .DeleteReviewedOnComic_OfAUser_ByUserIdAsync(userId, comicId);

            await _unitOfWork
                .SaveAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Delete Reviewed On Comic Of A User", args: DateTime.Now);
        }

        public async Task DeleteUserReviewedChapterByIdAsync(Guid userId, Guid chapterId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Delete Reviewed On Chapter Of A User", args: DateTime.Now);

            await _unitOfWork
                .ReviewChapterRepository
                .DeleteReviewedOnChapter_OfAUser_ByUserIdAsync(userId, chapterId);

            await _unitOfWork
                .SaveAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: Finish Delete Reviewed On Chapter Of A User", args: DateTime.Now);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public async Task AddOneUserToDatabaseAsync(UserModel userModel)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Adding A User To Database", args: DateTime.Now);

            await _unitOfWork
                .UserInfoRepository
                .AddAsync(entity: _mapper.Map<UserEntity>(source: userModel));

            await _unitOfWork.SaveAsync();

            _logger.LogWarning(message: "[{DateTime.Now}]: End Adding A User To Database", args: DateTime.Now);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<bool> CheckIfUserIsExistedByUsernameAsync(string username)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start querying user table", args: DateTime.Now);

            var result = await _unitOfWork
                .UserInfoRepository
                .CheckUserIsExistedByUsernameAsync(username: username);

            _logger.LogWarning(message: "[{DateTime.Now}]: End querying user table", args: DateTime.Now);

            return result;
        }
    }
}