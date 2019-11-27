using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();

            return View(context.Model.OrderBy(x => x.bid).ToList());
        }

        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            DatabaseContext context = new DatabaseContext();

            var item = from CyberTruck in context.Model
                       where model.Id == id
                       select User;

            return View(item.FirstOrDefault());
        }
    }
}