using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using UdemyCarBook.Dto.BrandDtos;
using UdemyCarBook.Dto.RentACarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
	public class RentACarListController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public RentACarListController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index(int id)
		{
			//var bookpickdate = TempData["bookpickdate"];
			//var bookoffdate = TempData["bookoffdate"];
			//var timepick = TempData["timepick"];
			//var timeoff = TempData["timeoff"];

			//filterRentACarDto.LocationID = int.Parse(locationID.ToString());
			//filterRentACarDto.Available = true;

			//TempData["bookpickdate"] = bookpickdate;
			//TempData["bookoffdate"] = bookoffdate;
			//TempData["timepick"] = timepick;
			//TempData["timeoff"] = timeoff;

			var locationID = TempData["locationID"];
			id = int.Parse(locationID.ToString());
			TempData["locationID"] = locationID;

			ViewBag.locationID = locationID;

			var client = _httpClientFactory.CreateClient(); //istemci anlamına geliyor.
			var responseMessage = await client.GetAsync($"https://localhost:7038/api/RentACars?locationID={id}&available=true");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
