using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardComponents;

public class _AdminDashboardStatisticsComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        Random random = new Random();
        int v1 = random.Next(0, 101);
        var client = _httpClientFactory.CreateClient(); //istemci anlamına geliyor.

        #region GetCarCount
        var responseMessage = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarCount");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
            ViewBag.v = values.CarCount;
            ViewBag.v1 = v1;
        }
        #endregion

        # region GetLocationCount
        var responseMessage2 = await client.GetAsync("https://localhost:7038/api/Statistics/GetLocationCount");
        if (responseMessage2.IsSuccessStatusCode)
        {
            int locationCountRandom = random.Next(0, 101);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
            ViewBag.locationCount = values2.LocationCount;
            ViewBag.locationCountRandom = locationCountRandom;
        }

        #endregion

        #region GetBrandCount

        var responseMessage5 = await client.GetAsync("https://localhost:7038/api/Statistics/GetBrandCount");
        if (responseMessage5.IsSuccessStatusCode)
        {
            int brandCountRandom = random.Next(0, 101);
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
            ViewBag.brandCount = values5.BrandCount;
            ViewBag.brandCountRandom = brandCountRandom;
        }

        #endregion

        #region GetAvgRentPriceForDaily

        var responseMessage6 = await client.GetAsync("https://localhost:7038/api/Statistics/GetAvgRentPriceForDaily");
        if (responseMessage6.IsSuccessStatusCode)
        {
            int avgRentPriceForDailyRandom = random.Next(0, 101);
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
            ViewBag.avgRentPriceForDaily = values6!.AvgRentPriceForDaily;
            ViewBag.avgRentPriceForDailyRandom = avgRentPriceForDailyRandom;
        }

        #endregion

        return View();
    }
}
