using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.RentACarFilterComponents
{
	public class _RentACarFilterListComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke(string v)
		{
			v = "aaa";
			TempData["value"] = v;
			return View();
		}
	}
}