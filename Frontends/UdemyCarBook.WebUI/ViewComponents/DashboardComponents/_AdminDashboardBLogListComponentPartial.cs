using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.BlogDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardComponents;

public class _AdminDashboardBLogListComponentPartial : ViewComponent
{

    private readonly IHttpClientFactory _httpClientFactory;

    public _AdminDashboardBLogListComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient(); //istemci anlamına geliyor.
        var responseMessage = await client.GetAsync("https://localhost:7038/api/Blogs/GetAllBlogsWithAuthorList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
