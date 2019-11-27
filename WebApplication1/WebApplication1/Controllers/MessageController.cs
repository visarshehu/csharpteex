using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            return View(db.Messages.ToList());
        }
    }
}