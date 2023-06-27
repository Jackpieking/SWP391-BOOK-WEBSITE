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
                UserAccountBalance = user.UserAccountBalance
            })
            .ToListAsync();
    }

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
                UserAccountBalance = user.UserAccountBalance
            })
            .FirstOrDefaultAsync();
    }

    public async Task DeleteUserByIdAsync(Guid userId)
    {
        UserEntity userNeedToDelete = await GetUserDetailsById(userId);
        if (userNeedToDelete != null)
        {
            _dbSet.Remove(userNeedToDelete);
        }
    }

}
