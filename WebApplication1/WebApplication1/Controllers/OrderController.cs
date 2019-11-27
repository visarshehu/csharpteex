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
            DatabaseContext c = new DatabaseContext();
            var orders = from s in c.Order
                           where s.Bid <= 100
                           orderby s.DateOfOrder descending
                           select s;
            return View(c.Order.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}