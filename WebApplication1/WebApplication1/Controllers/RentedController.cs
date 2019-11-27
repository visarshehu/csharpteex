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
            var res = from s in s.Renteds
                           where s.LicencePlate
                           select s;
            return View(c.res.ToList());
        }
    }
}