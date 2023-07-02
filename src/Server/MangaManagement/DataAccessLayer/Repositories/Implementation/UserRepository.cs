using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class UserRepository : GenericRepository<UserEntity>, IUserRepository
{
    public UserRepository(DbSet<UserEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// Get basic infos of a user
    /// </summary>
    /// <returns>Task<IList<UserEntity>></returns>
    public async Task<IList<UserEntity>> GetAllUserAsync()
    {
        return await _dbSet
            .Select(user => new UserEntity
            {
                UserIdentifier = user.UserIdentifier,
                Username = user.Username,
                UserFullName = user.UserFullName,
                UserPhoneNumber = user.UserPhoneNumber,
                UserEmail = user.UserEmail,
                UserBirthday = user.UserBirthday,
                UserGender = user.UserGender,
                UserAccountBalance = user.UserAccountBalance,
                PublisherEntity = user.PublisherEntity
            })
            .ToListAsync();
    }

    /// <summary>
    /// Get Basic infos of a user by userId
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>Task<UserEntity></returns>
    public async Task<UserEntity> GetUserDetailsById(Guid userId)
    {
        return await _dbSet
            .Where(user => user.UserIdentifier.Equals(userId))
            .Select(user => new UserEntity
            {
                UserIdentifier = user.UserIdentifier,
                Username = user.Username,
                UserFullName = user.UserFullName,
                UserPhoneNumber = user.UserPhoneNumber,
                UserEmail = user.UserEmail,
                UserBirthday = user.UserBirthday,
                UserGender = user.UserGender,
                UserAccountBalance = user.UserAccountBalance,
                PublisherEntity = user.PublisherEntity
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Delete user by userId
    /// </summary>
    /// <param name="userId"></param>
    public async Task DeleteUserByIdAsync(Guid userId)
    {
        var userNeedToDelete = await _dbSet.FindAsync(userId);
        if (userNeedToDelete != null)
        {
            _dbSet.Remove(userNeedToDelete);
        }
    }


    /// <summary>
    /// Admin Update basic infos of a user by take an Enity as arg
    /// </summary>
    /// <param name="user"></param>
    /// <exception cref="Exception"></exception>
    public async Task UpdateUserAsync(UserEntity user)
    {
        var existingUser = await _dbSet.FindAsync(user.UserIdentifier);
        if (existingUser != null)
        {
            // Update the properties of the existing user with the values from the updated user
            existingUser.UserFullName = user.UserFullName;
            existingUser.Username = user.Username;
            existingUser.UserGender = user.UserGender;
            existingUser.UserBirthday = user.UserBirthday;
        }
        else
        {
            throw new Exception("User not found."); // Or handle the error appropriately
        }
    }
}
