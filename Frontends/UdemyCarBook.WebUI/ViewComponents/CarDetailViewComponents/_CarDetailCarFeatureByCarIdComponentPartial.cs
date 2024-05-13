using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarFeatureDtos;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailCarFeatureByCarIdComponentPartial : ViewComponent
{

	private readonly IHttpClientFactory _httpClientFactory;

	public _CarDetailCarFeatureByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}

	[Route("Index/{id}")]
	[HttpGet]
	public async Task<IViewComponentResult> InvokeAsync(int id)
	{
		ViewBag.carId = id;
		var client = _httpClientFactory.CreateClient(); //istemci anlamına geliyor.
		var responseMessage = await client.GetAsync("https://localhost:7038/api/CarFeatures?id=" + id);
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCarFeautureByCarIdDto>>(jsonData);
			return View(values);
		}
		return View();
	}

}
