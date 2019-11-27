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
			DatabaseContext c = new DatabaseContext();
			var messages = from s in c.Messages
						   where s.Id < 10
						   orderby s.DateSent descending
						   select s.MessageText;
			return View(c.Messages.ToList());
		}
			public IActionResult Create()
			{
				return View();
			}

		[HttpPost]
		public IActionResult Create(Message s)
		{
			DatabaseContext c = new DatabaseContext();
			c.Messages.Add(s);
			c.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
	}

}
    
