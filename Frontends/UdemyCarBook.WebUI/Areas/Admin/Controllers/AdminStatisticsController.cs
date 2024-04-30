using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
[Route("Admin/AdminStatistics")]
public class AdminStatisticsController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminStatisticsController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
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

        #region GetAuthorCount

        var responseMessage3 = await client.GetAsync("https://localhost:7038/api/Statistics/GetAuthorCount");
        if (responseMessage3.IsSuccessStatusCode)
        {
            int authorCountRandom = random.Next(0, 101);
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
            ViewBag.authorCount = values3.AuthorCount;
            ViewBag.authorCountRandom = authorCountRandom;
        }

        #endregion

        #region GetBlogCount

        var responseMessage4 = await client.GetAsync("https://localhost:7038/api/Statistics/GetBlogCount");
        if (responseMessage4.IsSuccessStatusCode)
        {
            int blogCountRandom = random.Next(0, 101);
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
            ViewBag.blogCount = values4.BlogCount;
            ViewBag.blogCountRandom = blogCountRandom;
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

        #region GetAvgRentPriceForWeekly

        var responseMessage7 = await client.GetAsync("https://localhost:7038/api/Statistics/GetAvgRentPriceForWeekly");
        if (responseMessage7.IsSuccessStatusCode)
        {
            int avgRentPriceForWeeklyRandom = random.Next(0, 101);
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
            ViewBag.avgRentPriceForWeekly = values7!.AvgRentPriceForWeekly;
            ViewBag.avgRentPriceForWeeklyRandom = avgRentPriceForWeeklyRandom;
        }

        #endregion

        #region GetAvgRentPriceForMonthly

        var responseMessage8 = await client.GetAsync("https://localhost:7038/api/Statistics/GetAvgRentPriceForMonthly");
        if (responseMessage8.IsSuccessStatusCode)
        {
            int avgRentPriceForMonthlyRandom = random.Next(0, 101);
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
            ViewBag.avgRentPriceForMonthly = values8!.AvgRentPriceForMonthly;
            ViewBag.avgRentPriceForMonthlyRandom = avgRentPriceForMonthlyRandom;
        }

        #endregion

        #region GetCarCountByTransmissionIsAuto

        var responseMessage9 = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarCountByTransmissionIsAuto");
        if (responseMessage9.IsSuccessStatusCode)
        {
            int carCountByTransmissionIsAutoRandom = random.Next(0, 101);
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
            ViewBag.carCountByTransmissionIsAuto = values9!.CarCountByTransmissionIsAuto;
            ViewBag.carCountByTransmissionIsAutoRandom = carCountByTransmissionIsAutoRandom;
        }

        #endregion

        #region GetBrandNameByMaxCar

        var responseMessage10 = await client.GetAsync("https://localhost:7038/api/Statistics/GetBrandNameByMaxCar");
        if (responseMessage10.IsSuccessStatusCode)
        {
            int bBrandNameByMaxCarRandom = random.Next(0, 101);
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
            ViewBag.bBrandNameByMaxCar = values10!.BrandNameByMaxCar;
            ViewBag.bBrandNameByMaxCarRandom = bBrandNameByMaxCarRandom;
        }
        #endregion

        #region GetBlogTitleByMaxBlogComment-11

        var responseMessage11 = await client.GetAsync("https://localhost:7038/api/Statistics/GetBlogTitleByMaxBlogComment");
        if (responseMessage11.IsSuccessStatusCode)
        {
            int blogTitleByMaxBlogComment = random.Next(0, 101);
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
            ViewBag.blogTitleByMaxBlogComment = values11!.BlogTitleByMaxBlogComment;
            ViewBag.blogTitleByMaxBlogCommentRandom = blogTitleByMaxBlogComment;
        }

        #endregion

        #region CarCountBySmallerThan1000-12

        var responseMessage12 = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarCountBySmallerThan1000");
        if (responseMessage12.IsSuccessStatusCode)
        {
            int carCountBySmallerThan1000Random = random.Next(0, 101);
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
            ViewBag.carCountBySmallerThan1000 = values12!.CarCountBySmallerThan1000;
            ViewBag.carCountBySmallerThan1000Random = carCountBySmallerThan1000Random;
        }

        #endregion

        #region GetCarCountByFuelGasolineOrDiesel-13

        var responseMessage13 = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
        if (responseMessage13.IsSuccessStatusCode)
        {
            int carCountByFuelGasolineOrDieselRandom = random.Next(0, 101);
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
            ViewBag.carCountByFuelGasolineOrDiesel = values13!.CarCountByFuelGasolineOrDiesel;
            ViewBag.carCountByFuelGasolineOrDieselRandom = carCountByFuelGasolineOrDieselRandom;
        }

        #endregion

        #region GetCarCountByFuelElectric-14

        var responseMessage14 = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarCountByFuelElectric");
        if (responseMessage14.IsSuccessStatusCode)
        {
            int CarCountByFuelElectricRandom = random.Next(0, 101);
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
            ViewBag.CarCountByFuelElectric = values14!.CarCountByFuelElectric;
            ViewBag.CarCountByFuelElectricRandom = CarCountByFuelElectricRandom;
        }

        #endregion

        #region GetCarBrandAndModelByRentPriceDailyMax-15

        var responseMessage15 = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
        if (responseMessage15.IsSuccessStatusCode)
        {
            int carBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
            ViewBag.CarBrandAndModelByRentPriceDailyMax = values15!.CarBrandAndModelByRentPriceDailyMax;
            ViewBag.CarBrandAndModelByRentPriceDailyMaxRandom = carBrandAndModelByRentPriceDailyMaxRandom;
        }

        #endregion

        #region GetCarBrandAndModelByRentPriceDailyMin-16

        var responseMessage16 = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
        if (responseMessage16.IsSuccessStatusCode)
        {
            int carBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
            ViewBag.CarBrandAndModelByRentPriceDailyMin = values16!.CarBrandAndModelByRentPriceDailyMin;
            ViewBag.CarBrandAndModelByRentPriceDailyMinRandom = carBrandAndModelByRentPriceDailyMinRandom;
        }

        #endregion






        return View();
    }
}
