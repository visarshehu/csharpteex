using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();
            var OrderList = from o in context.Orders
                            select o;
         return View(OrderList.ToList());
        }
        public IActionResult Create()
        {
            return View();

           }
        public IActionResult Create(Order o)
        {
            DatabaseContext context = new DatabaseContext();
            context.Orders.Add(o);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}