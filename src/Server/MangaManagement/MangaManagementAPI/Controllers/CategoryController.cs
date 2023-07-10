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
    private readonly EntityManagementService _entityManagementService;

    public CategoryController(ILogger<CategoryModel> logger, EntityManagementService entityManagementService)
    {
        _logger = logger;
        _entityManagementService = entityManagementService;
    }

    public async Task<IActionResult> DeleteCat(Guid id)
    {
        await _entityManagementService.Delete(DefinedEntity.Category, id);

        return RedirectToPage("/Pages/comics");
    }

    public async Task<IActionResult> EditCategory(Guid id)
    {
        var category = await _entityManagementService.GetCategoryByIdAsync(Guid.Parse((string)Request.RouteValues["id"]));
        if (category == null) return NotFound();
        return View(category);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateCategory(Guid catId, string catName, string catDescription)
    {
        await _entityManagementService.UpdateCategoryAsync(catId, catName, catDescription);
        return RedirectToPage("/Pages/comics");
    }
}
