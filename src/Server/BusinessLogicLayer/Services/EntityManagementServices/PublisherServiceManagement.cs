using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.EntityManagementServices;

public class PublisherServiceManagement
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<PublisherServiceManagement> _logger;

    public PublisherServiceManagement(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ILogger<PublisherServiceManagement> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get publisher with userInfo reference by publisherIdentifier from database
    /// </summary>
    /// <returns>Publisher</returns>
    public async Task<PublisherModel> GetPublisherWithUserByPublisherIdentifierAsync(Guid publisherIdentifier)
    {
        var publisherEntity = await _unitOfWork
            .PublisherRepository
            .GetPublisherWithUserByPublisherIdentifierFromDatabaseAsync(publisherIdentifier: publisherIdentifier);

        return _mapper.Map<PublisherModel>(source: publisherEntity);
    }
}