using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using Entity;

namespace BusinessLogicLayer.Services
{
    public class PublisherManagementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PublisherManagementService> _logger;

        public PublisherManagementService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<PublisherManagementService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        /// <summary>
        /// Get publishser 
        /// </summary>
        /// <param name="publisherId"></param>
        /// <returns></returns>
        public async Task<PublisherModel> GetPublisherComicByPublisherId(Guid publisherId)
        {
            _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Publisher Table", args: DateTime.Now);

            var publisher = await
                 _unitOfWork
                .PublisherRepository
                .GetAllPublisherComicsByPublisherId(publisherId);

            _logger.LogWarning(message: "[{DateTime.Now}]: Finished Querying On Publisher Table", args: DateTime.Now);

            return _mapper.Map<PublisherModel>(publisher);
        }
    }
}