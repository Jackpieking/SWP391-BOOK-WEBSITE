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
        var comic = await _entityManagementService.GetComicByIdNoRelationAsync(id);
        if (comic == null) return NotFound();
        return View(comic);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, ComicModel comic)
    {
        if (id != comic.ComicIdentifier) return Content(comic.ComicIdentifier + "");
        await _entityManagementService.UpdateComic(comic);
        return RedirectToRoute(new
        {
            controller = "Comics",
            action = "Details",
            id = id
        });
    }

    public ActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ComicModel comic)
    {
        if (comic == null) return NotFound();
        comic.PublisherIdentifier = Guid.Parse("51b02aef-2b58-4433-adea-e73c37b9f224");
        comic.ComicIdentifier = Guid.NewGuid();
        await _entityManagementService.CreateComic(comic);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(Guid id)
    {
        var comic = await _entityManagementService.GetComicByIdAsync(comicId: id);
        ViewData["categories"] = _entityManagementService.GetCategoriesByComicId(comicId: id);
        return View(comic);
    }
}
