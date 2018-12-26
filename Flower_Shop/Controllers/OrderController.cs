using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower_Shop.Models.Context;
using Flower_Shop.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flower_Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ProjectContext _Context;

        public OrderController(ProjectContext context)
        {
            _Context = context;
        }

        public IActionResult OrderList()
        {
            return View(_Context.Orders.ToList());
        }

        public IActionResult OrderInfo(int id)
        {
            var get = _Context.Flowers.Find(id);
            ViewBag.image = get.ImgPath;
            ViewBag.name = get.Name;
            var model = new Order()
            {
                OrderId = get.FlowerId,
                Price = get.Price
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Pay(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderTime = DateTime.Now;

                _Context.Orders.Add(order);
                _Context.SaveChanges();
                return RedirectToAction("OrderList");
            }

            return View("OrderInfo", order);
        }
    }
}