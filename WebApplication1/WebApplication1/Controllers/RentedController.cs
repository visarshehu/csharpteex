using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RentedController : Controller
    {
       public IActionResult Index()
       {
           DatabaseContext c = new DatabaseContext();
             return View(c.User.ToList());
}


        public IActionResult Create()
        {
            return View();

        }
        public IActionResult Create(User s)
        {
            DatabaseContext c = new DatabaseContext();
            c.User.Add(s);
            c.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
