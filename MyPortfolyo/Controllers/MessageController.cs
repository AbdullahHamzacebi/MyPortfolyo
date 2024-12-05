﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.Controllers
{
	public class MessageController : Controller
	{
		MyPortolioContext context = new MyPortolioContext();
		public IActionResult Inbox()
		{
			var values = context.Messages.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var value = context.Messages.Find(id);
		    return View(value);
		}
	}
}