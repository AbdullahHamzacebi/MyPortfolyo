using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortolioContext context = new MyPortolioContext();
		public IActionResult Index()
		{
			var values = context.toDoLists.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			context.toDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var value = context.toDoLists.Find(id);
			context.toDoLists.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");

		}

		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value = context.toDoLists.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			context.toDoLists.Update(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeToDoListStatusToTrue(int id)
		{
			var value = context.toDoLists.Find(id);
			value.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}


		public IActionResult ChangeToDoListStatusToFalse(int id)
		{
			var value = context.toDoLists.Find(id);
			value.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
