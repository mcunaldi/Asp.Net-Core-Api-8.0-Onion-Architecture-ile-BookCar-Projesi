using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarDescriptionDtos;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailCarDescriptionByCarIdComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _CarDetailCarDescriptionByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    [Route("UpdateLocation/{id}")]
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        ViewBag.CarId = id;
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7038/api/CarDescriptions?carId=" + id);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultCarDescriptionByCarIdDto>(jsonData);
            return View(values);
        }

        return View();
    }

}
