using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers
{
    public class ChapterController : Controller
    {
        private readonly ComicManagementService _entityManagementService;

        private ChapterController(ComicManagementService entityManagementService) =>
            _entityManagementService = entityManagementService;

        // GET: ChapterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChapterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChapterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChapterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChapterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChapterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: ChapterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (id.Equals(null)) return NotFound();
            try
            {
                await _entityManagementService.Delete(DefinedEntity.Chapter, id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
