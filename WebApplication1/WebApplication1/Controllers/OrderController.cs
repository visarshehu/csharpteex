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
        public IActionResult Index(int n)
        {
            DatabaseContext context = new DatabaseContext();

            return View();
        }
         
        }
    }
