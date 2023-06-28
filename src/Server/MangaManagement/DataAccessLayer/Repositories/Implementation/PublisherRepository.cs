using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class PublisherRepository : GenericRepository<PublisherEntity>, IPublisherRepository
{
    public PublisherRepository(DbSet<PublisherEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// Select from "publisher" table with these fields:
    /// - Field Username of "user" table
    /// Requirement: equal to given publisherIdentifier
    /// </summary>
    /// <param name="publisherIdentifier"></param>
    /// <returns>Task<PublisherEntity></returns>
    public async Task<PublisherEntity> GetPublisherWith_UsernameByPublisherIdAsync(Guid publisherIdentifier)
    {
        return await _dbSet
            .Where(predicate: publisherEntity
                => publisherEntity.PublisherIdentifier == publisherIdentifier)
            .Select(selector: publisherEntity => new PublisherEntity
            {
                UserEntity = new()
                {
                    Username = publisherEntity.UserEntity.Username
                }
            })
            .FirstOrDefaultAsync();
    }
}
