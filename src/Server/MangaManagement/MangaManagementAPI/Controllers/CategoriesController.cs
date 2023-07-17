using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

public class CategoriesController : Controller
{
    private readonly ILogger<CategoryModel> _logger;
    private readonly ComicManagementService _entityManagementService;

    public CategoriesController(ILogger<CategoryModel> logger, ComicManagementService entityManagementService)
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
        if (category.CategoryDescription == null) category.CategoryDescription = "";
        await _entityManagementService.UpdateCategory(category);
        return RedirectToRoute(new
        {
            controller = "Categories",
            action = "Index"
        });
    }

    // GET: CategoryController/Create
    public ActionResult Create() => View();

    // POST: CategoryController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(CategoryModel category)
    {
        try
        {
            if (ModelState.IsValid)
            {
                category.CategoryIdentifier = Guid.NewGuid();
                await _entityManagementService.CreateCategory(category);
                await Console.Out.WriteLineAsync("Create Finish");
            }
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return View();
        }
    }
}
