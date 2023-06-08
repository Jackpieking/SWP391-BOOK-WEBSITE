using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class UserInfoRepository : GenericRepository<UserInfoEntity>, IUserInfoRepository
{
	public UserInfoRepository(DbSet<UserInfoEntity> dbSet) : base(dbSet)
	{
	}
}
