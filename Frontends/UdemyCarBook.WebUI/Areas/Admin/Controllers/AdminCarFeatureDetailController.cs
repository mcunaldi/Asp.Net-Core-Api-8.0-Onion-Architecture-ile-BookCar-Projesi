using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarFeatureDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/AdminCarFeatureDetail")]
public class AdminCarFeatureDetailController : Controller
{

    private readonly IHttpClientFactory _httpClientFactory;

    public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index/{id}")]
    public async Task<IActionResult> Index(int id)
    {
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
