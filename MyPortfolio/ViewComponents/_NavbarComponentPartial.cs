using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext Context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
