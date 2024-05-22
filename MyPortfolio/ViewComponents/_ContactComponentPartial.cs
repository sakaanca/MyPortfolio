using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactTtle = Context.Contacts.Select(x => x.Ttle).ToList().FirstOrDefault();
            ViewBag.contactDesciption = Context.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactPhone1 = Context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.contactPhone2 = Context.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.contactEmail1 = Context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.contactEmail2 = Context.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.contactAdress = Context.Contacts.Select(x => x.Adress).FirstOrDefault();
            return View();
        }
    }
}
