﻿using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IPublisherRepository : IGenericRepository<PublisherEntity>
{
	Task<PublisherEntity> GetPublisherWith_UsernameByPublisherIdAsync(Guid publisherIdentifier);
}
