using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Outgoing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using static DTO.Outgoing.GetPublisherAction_Out_Dto;

namespace MangaManagementAPI.Views.Pages
{
    public class PublisherAllComicModel : PageModel
    {
        private readonly ILogger<PublisherAllComicModel> _logger;
        private readonly PublisherManagementService _publisherManagementService;
        private readonly IMapper _mapper;
        public GetPublisherAction_Out_Dto PublisherDto { get; set; }

        public PublisherAllComicModel(ILogger<PublisherAllComicModel> logger, UserManagementService userManagementService, PublisherManagementService publisherManagementService, IMapper mapper)
        {
            _logger = logger;
            _publisherManagementService = publisherManagementService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetGetPublisherComic([FromRoute] Guid publisherId)
        {
            _logger.LogCritical(message: "Start Transaction To Get All Comic Of A Publisher !!");

            try
            {
                var publisher = await
                             _publisherManagementService
                            .GetPublisherComicByPublisherId(publisherId);

                GetPublisherAction_Out_Dto publisherDto = new()
                {
                    ComicDto = _mapper.Map<ICollection<PublisherComicOutDto>>(publisher.ComicModels),
                    PublisherIdentifier = publisher.PublisherIdentifier,
                    PublisherDescription = publisher.PublisherDescription
                };

                PublisherDto = publisherDto;

                return Page();
            }
            catch (TaskCanceledException TC_e)
            {
                _logger.LogError("[{DateTime.Now}] - Error: {TC_2.Message}", DateTime.Now, TC_e.Message);

                return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
            }
            catch (HttpRequestException HR_e)
            {
                _logger.LogError("[{DateTime.Now}] - Error: {HR_e.Message}", DateTime.Now, HR_e.Message);

                return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
            }
            finally
            {
                _logger.LogCritical(message: "Finished Transaction To Get All Comic Of A Publisher !!");
            }
        }
    }
}