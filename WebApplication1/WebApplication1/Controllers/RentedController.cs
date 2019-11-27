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
            var Rentcars = from s in c.RentedC
                           where s.DateofReurn == null
                           orderby s.DateofRent 
                           select s.LicensePlate;

        }
        public ActionResult Index()
        {
            return View(AddCarView)
                }
    }
}