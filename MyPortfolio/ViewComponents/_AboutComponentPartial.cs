using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent

    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=Context.Abouts.Select(x => x.Title).ToList().FirstOrDefault();
            ViewBag.aboutSubDesciption = Context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=Context.Abouts.Select(x =>x.Details).FirstOrDefault();

            return View();
        }
    }
}
