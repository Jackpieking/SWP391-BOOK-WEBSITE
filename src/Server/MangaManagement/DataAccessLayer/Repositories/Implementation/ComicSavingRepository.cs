using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicSavingRepository : GenericRepository<ComicSavingEntity>, IComicSavingRepository
{
    public ComicSavingRepository(DbSet<ComicSavingEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public async Task<IList<ComicSavingEntity>> GetComicSavingsOfAUserByUserId(Guid userId)
    {
        return await _dbSet
            .Where(comincSaving => comincSaving.UserIdentifier.Equals(userId))
            .Select(comicSaving => new ComicSavingEntity
            {
                ComicEntity = new ComicEntity()
                {
                    ComicName = comicSaving.ComicEntity.ComicName
                },
                SavingTime = comicSaving.SavingTime,
            })
            .ToListAsync();
    }

}
