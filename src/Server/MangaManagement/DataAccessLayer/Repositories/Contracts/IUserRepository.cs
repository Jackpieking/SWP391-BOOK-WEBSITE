using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IUserRepository : IGenericRepository<UserEntity>
{

	Task<IList<UserEntity>> GetUsersAsync();
	Task<UserEntity> GetUserDetailsByUserIdAsync(Guid id);
	Task DeleteUserByUserIdAsync(Guid id);
}
