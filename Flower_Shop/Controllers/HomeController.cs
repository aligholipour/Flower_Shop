using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower_Shop.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace Flower_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectContext _context;

        public HomeController(ProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Flowers.OrderByDescending(f=>f.FlowerId).ToList());
        }
    }
}