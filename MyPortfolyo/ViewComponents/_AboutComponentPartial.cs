using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortolioContext portolioContext = new MyPortolioContext();
        public IViewComponentResult Invoke()
        {
            
            ViewBag.aboutTitle = portolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
