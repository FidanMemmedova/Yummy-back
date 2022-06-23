using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy.DAL;
using Yummy.Helpers;
using Yummy.Models;


namespace Yummy.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class FoodController : Controller
    {
        private AppDbContext _context { get;}
       private IWebHostEnvironment _env { get; }
        public FoodController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: FoodController
        public ActionResult Index()
        {
            return View(_context.Foods);
        }

        // GET: FoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Food food)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!food.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("photo", "az olmalidi 200den");
                return View();
            }
            if (!food.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("photo", "sekil olmalidi");
                return View();
            }
            food.Image = await food.Photo.SaveFileAsync(_env.WebRootPath, "image");
            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: FoodController/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }

        // POST: FoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, IFormCollection collection)
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

        // GET: FoodController/Delete/5

        // POST: FoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var food = _context.Foods.Find(id);
            if (food==null)
            {
                return NotFound();
            }
            var path = Helper.GetPath(_env.WebRootPath, "image", food.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
