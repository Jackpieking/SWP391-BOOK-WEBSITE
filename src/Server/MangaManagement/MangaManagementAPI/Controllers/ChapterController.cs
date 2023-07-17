﻿using BusinessLogicLayer.Services;
using Helper.DefinedEnums;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers
{
    public class ChapterController : Controller
    {
        private readonly ComicManagementService _entityManagementService;

        public ChapterController(ComicManagementService entityManagementService) =>
            _entityManagementService = entityManagementService;

        // GET: ChapterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChapterController/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var chapter = await _entityManagementService.GetChapterByIdAsync(id);
            return View(chapter);
        }

        // GET: ChapterController/Create
        public ActionResult Create(Guid id)
        {
            ViewData["comicId"] = id;
            return View();
        }

        // POST: ChapterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ChapterModel chapter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    chapter.ChapterIdentifier = Guid.NewGuid();
                    chapter.AddedDate = DateOnly.FromDateTime(DateTime.Now);
                    await _entityManagementService.CreateChapter(chapter);
                }
                return RedirectToRoute(new
                {
                    controller = "Comics",
                    action = "Details",
                    id = chapter.ComicIdentifier
                });
            }
            catch
            {
                return View();
            }
        }

        // GET: ChapterController/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var chapter = await _entityManagementService.GetChapterByIdAsync(id);
            if (chapter == null) return NotFound();
            return View(chapter);
        }

        // POST: ChapterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id, ChapterModel chapter)
        {
            try
            {
                if (id != chapter.ChapterIdentifier)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    await _entityManagementService.UpdateChapter(chapter);
                }
                return RedirectToRoute(new
                {
                    controller = "Comics",
                    action = "Details",
                    id = chapter.ComicIdentifier
                });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                Console.WriteLine(ex.Message);
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