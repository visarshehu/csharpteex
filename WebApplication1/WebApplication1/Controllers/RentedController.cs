using System;
using System.Collections.Generic;
using System.Globalization;
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
            var students = from LicencePlate in c.Cars
                           where LicencePlate==DateOfRent
                           orderby DateOfRent Sorted
                           select LicencePlate;


             
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car c)
        {
            DatabaseContext c = new DatabaseContext();
            c.Cars.Add(c);
            c.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
}