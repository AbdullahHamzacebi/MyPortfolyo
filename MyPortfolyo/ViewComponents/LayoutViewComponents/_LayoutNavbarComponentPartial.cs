using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		MyPortolioContext context = new MyPortolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.toDoLists.Where(x => x.Status == false).Count();
			var values = context.toDoLists.Where(x => x.Status == false).ToList();
			return View(values);
		}
	}
}
