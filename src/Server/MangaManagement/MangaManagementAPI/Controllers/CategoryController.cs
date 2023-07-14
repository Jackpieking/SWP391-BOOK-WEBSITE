using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryModel> _logger;
    private readonly ComicManagementService _entityManagementService;

    public CategoryController(ILogger<CategoryModel> logger, ComicManagementService entityManagementService)
    {
        _logger = logger;
        _entityManagementService = entityManagementService;
    }

    // GET: CategoryController
    public async Task<ActionResult> Index()
    {
        var categories = await _entityManagementService.GetAllCategoryNoRelationAsync();
        return View(categories);
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        await _entityManagementService.Delete(DefinedEntity.Category, id);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        if (id.Equals(null)) return NotFound();
        var category = await _entityManagementService.GetCategoryByIdAsync(Guid.Parse((string)Request.RouteValues["id"]));
        if (category == null) return NotFound();
        return View(category);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, CategoryModel category)
    {
        await _entityManagementService.UpdateCategory(category);
        return RedirectToPage("/Category/Edit/" + id);
    }
}
