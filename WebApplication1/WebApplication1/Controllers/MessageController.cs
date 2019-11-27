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
            DatabaseContext context = new DatabaseContext();
            var query = (from q in context.ChatRooms
                         orderby q.DateCreated descending
                         select q).Take(10);

            return View(context.Messages.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Message message)
        {
            DatabaseContext context = new DatabaseContext();
            context.Add(message);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}