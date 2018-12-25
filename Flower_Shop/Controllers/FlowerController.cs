using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower_Shop.Models.Context;
using Flower_Shop.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flower_Shop.Controllers
{
    public class FlowerController : Controller
    {
        private readonly ProjectContext _context;

        public FlowerController(ProjectContext context)
        {
            _context = context;
        }

        public IActionResult FlowerList()
        {
            return View(_context.Flowers.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Flower flower)
        {
            _context.Add(flower);
            _context.SaveChanges();
            return RedirectToAction("FlowerList");
        }

        public IActionResult Edit(int id)
        {
            var find = _context.Flowers.Find(id);
            return View(find);
        }

        [HttpOptions]
        public IActionResult Edit(Flower flower)
        {
            if (!ModelState.IsValid)
            {
                return View(flower);
            }

            _context.Entry(flower).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("FlowerList");
        }

        public IActionResult Delete(int id)
        {
            var find = _context.Flowers.Find(id);
            _context.Entry(find).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("FlowerList");
        }

    }
}