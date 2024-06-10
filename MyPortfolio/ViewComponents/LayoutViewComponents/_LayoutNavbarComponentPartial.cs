using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial :ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{

			ViewBag.toDoListCount=context.ToDoLists.Where(x=>x.Status==false).Count();//ToDoList sınıfında ki yapılmamış olan işlemlerin sayısını bize verir
			var values = context.ToDoLists.Where(x => x.Status == false).ToList();//ToDoList sınıfında ki sadece yapılmamış olan işlemleri listeler
			return View(values);
		}
	}
}
