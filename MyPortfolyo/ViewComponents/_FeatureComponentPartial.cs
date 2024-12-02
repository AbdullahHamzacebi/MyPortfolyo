using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortolioContext portolioContext = new MyPortolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portolioContext.Features.ToList();
            return View(values);
        }
    }
}
