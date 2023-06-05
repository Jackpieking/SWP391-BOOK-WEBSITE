using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class UserInfoRepository : GenericRepository<UserInfo>, IUserInfoRepository
{
	public UserInfoRepository(DbSet<UserInfo> dbSet) : base(dbSet)
	{
	}
}
