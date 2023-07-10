using AutoMapper;
using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using MangaManagementAPI.Views.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

public class ComicsController : Controller
{
    private readonly ILogger<ComicsModel> _logger;
    private readonly EntityManagementService _entityManagementService;
    private readonly IMapper _mapper;

    public ComicsController(ILogger<ComicsModel> logger, EntityManagementService entityManagementService, IMapper mapper)
    {
        _logger = logger;
        _entityManagementService = entityManagementService;
        _mapper = mapper;
    }

    public async Task<IActionResult> DeleteComic(Guid id)
    {
        await _entityManagementService.Delete(DefinedEntity.Comic, id);

        return RedirectToPage("/Pages/comics");
    }

    public async Task<IActionResult> EditComic(Guid id)
    {
        var comic = await _entityManagementService.GetComicByIdNoRelationAsync(Guid.Parse((string)Request.RouteValues["id"]));
        if (comic == null) return NotFound();
        return View(comic);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateComic(Guid comicId, string comicName, string comicDes, string comicPDate, string comicStatus)
    {
        await _entityManagementService.UpdateComicAsync(comicId, comicName, comicDes, comicPDate, comicStatus);
        return RedirectToPage("/Pages/comics");
    }

    public async Task<IActionResult> AddComic(Guid id)
    {
        var comic = await _entityManagementService.GetComicByIdAsync(Guid.Parse((string)Request.RouteValues["id"]));
        if (comic == null) return NotFound();
        this.ViewData["comic"] = comic;
        return View();
    }

    public async Task<IActionResult> DetailsComic(Guid id)
    {
        ViewData["comic"] = await _entityManagementService.GetComicByIdAsync(comicId: id);
        //ViewData["categories"] = await _entityManagementService.GetCategoriesByComicIdAsync(comicId: id);
        return View();
    }

    public async Task<IActionResult> DeleteChap(Guid id)
    {
        await _entityManagementService.Delete(DefinedEntity.Chapter, id);

        return View();
    }
}
