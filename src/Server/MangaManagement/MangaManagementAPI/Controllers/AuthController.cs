using AutoMapper;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class AuthController
{
    private readonly EntityManagementService _entityManagementService;
    private readonly ILogger<AuthController> _logger;
    private readonly IMapper _mapper;

    public AuthController(
        EntityManagementService entityManagementService,
        ILogger<AuthController> logger,
        IMapper mapper)
    {
        _entityManagementService = entityManagementService;
        _logger = logger;
        _mapper = mapper;
    }


}
