using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class UserRepository : GenericRepository<UserEntity>, IUserRepository
{
	public UserRepository(DbSet<UserEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IList<UserEntity>> GetUsersAsync()
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

	/// <summary>
	///
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	public async Task<UserEntity> GetUserDetailsByUserIdAsync(Guid userId)
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

	/// <summary>
	///
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	public async Task DeleteUserByUserIdAsync(Guid userId)
	{
		UserEntity userNeedToDelete = await GetUserDetailsByUserIdAsync(userId);
		if (userNeedToDelete != null)
		{
			_dbSet.Remove(userNeedToDelete);
		}
	}

}
