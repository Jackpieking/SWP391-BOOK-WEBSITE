using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.Contracts.Base;
using Entity;

namespace DataAccessLayer.Repositories.Contracts;

public interface IUserRepository : IGenericRepository<UserEntity>
{
    
    Task<IList<UserEntity>> GetAllUserAsync();
    Task<UserEntity> GetUserDetailsById(Guid id);
    Task DeleteUserByIdAsync (Guid id);
}
