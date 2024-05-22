using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        MyPortfolioContext Context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
