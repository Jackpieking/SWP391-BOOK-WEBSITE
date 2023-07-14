using AutoMapper;
using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

public class ComicsController : Controller
{
    private readonly ILogger<ComicModel> _logger;
    private readonly ComicManagementService _entityManagementService;
    private readonly IMapper _mapper;

    public ComicsController(ILogger<ComicModel> logger, ComicManagementService entityManagementService, IMapper mapper)
    {
        _logger = logger;
        _entityManagementService = entityManagementService;
        _mapper = mapper;
    }

    // GET: ComicsController
    public async Task<ActionResult> Index()
    {
        var comics = await _entityManagementService.GetAllComicNoRelationAsync();
        return View(comics);
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        await _entityManagementService.Delete(DefinedEntity.Comic, id);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        var comic = await _entityManagementService.GetComicByIdNoRelationAsync(Guid.Parse((string)Request.RouteValues["id"]));
        if (comic == null) return NotFound();
        return View(comic);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Guid comicId, string comicName, string comicDes, string comicPDate, string comicStatus)
    {
        await _entityManagementService.UpdateComicAsync(comicId, comicName, comicDes, comicPDate, comicStatus);
        return RedirectToPage("/Comics/Edit/" + comicId);
    }

    public async Task<IActionResult> Create(Guid id)
    {
        var comic = await _entityManagementService.GetComicByIdAsync(Guid.Parse((string)Request.RouteValues["id"]));
        if (comic == null) return NotFound();
        this.ViewData["comic"] = comic;
        return View();
    }

    public async Task<IActionResult> Details(Guid id)
    {
        var comic = await _entityManagementService.GetComicByIdAsync(comicId: id);
        ViewData["categories"] = _entityManagementService.GetCategoriesByComicId(comicId: id);
        return View(comic);
    }
}
