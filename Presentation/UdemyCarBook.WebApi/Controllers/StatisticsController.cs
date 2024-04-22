using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StatisticsController(IMediator mediator) : ControllerBase
{

    [HttpGet("GetCarCount")]
    public async Task<IActionResult> GetCarCount()
    {
        var values = await mediator.Send(new GetCarCountQuery());
        return Ok(values);
    }

    [HttpGet("GetLocationCount")]
    public async Task<IActionResult> GetLocationCount()
    {
        var values = await mediator.Send(new GetLocationCountQuery());
        return Ok(values);
    }

    [HttpGet("GetAuthorCount")]
    public async Task<IActionResult> GetAuthorCount()
    {
        var values = await mediator.Send(new GetAuthorCountQuery());
        return Ok(values);
    }

    [HttpGet("GetBlogCount")]
    public async Task<IActionResult> GetBlogCount()
    {
        var values = await mediator.Send(new GetBlogCountQuery());
        return Ok(values);
    }

    [HttpGet("GetBrandCount")]
    public async Task<IActionResult> GetBrandCount()
    {
        var values = await mediator.Send(new GetBrandCountQuery());
        return Ok(values);
    }

    [HttpGet("GetAvgRentPriceForDaily")]
    public async Task<IActionResult> GetAvgRentPriceForDaily()
    {
        var values = await mediator.Send(new GetAvgRentPriceForDailyQuery());
        return Ok(values);
    }

    [HttpGet("GetAvgRentPriceForWeekly")]
    public async Task<IActionResult> GetAvgRentPriceForWeekly()
    {
        var values = await mediator.Send(new GetAvgRentPriceForWeeklyQuery());
        return Ok(values);
    }

    [HttpGet("GetAvgRentPriceForMonthly")]
    public async Task<IActionResult> GetAvgRentPriceForMonthly()
    {
        var values = await mediator.Send(new GetAvgRentPriceForMonthlyQuery());
        return Ok(values);
    }

    [HttpGet("GetCarCountByTransmissionIsAuto")]
    public async Task<IActionResult> GetCarCountByTransmissionIsAuto()
    {
        var values = await mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
        return Ok(values);
    }

    [HttpGet("GetBrandNameByMaxCar")]
    public async Task<IActionResult> GetBrandNameByMaxCar()
    {
        var values = await mediator.Send(new GetBrandNameByMaxCarQuery());
        return Ok(values);
    }

    [HttpGet("GetBlogTitleByMaxBlogComment")]
    public async Task<IActionResult> GetBlogTitleByMaxBlogComment()
    {
        var values = await mediator.Send(new GetBlogTitleByMaxBlogCommentQuery());
        return Ok(values);
    }

    [HttpGet("GetCarCountBySmallerThan1000")]
    public async Task<IActionResult> GetCarCountBySmallerThan1000()
    {
        var values = await mediator.Send(new GetCarCountBySmallerThan1000Query());
        return Ok(values);
    }

    [HttpGet("GetCarCountByFuelGasolineOrDiesel")]
    public async Task<IActionResult> GetCarCountByFuelGasolineOrDiesel()
    {
        var values = await mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
        return Ok(values);
    }

    [HttpGet("GetCarCountByFuelElectric")]
    public async Task<IActionResult> GetCarCountByFuelElectric()
    {
        var values = await mediator.Send(new GetCarCountByFuelElectricQuery());
        return Ok(values);
    }

    [HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
    public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMax()
    {
        var values = await mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery());
        return Ok(values);
    }

    [HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
    public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMin()
    {
        var values = await mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery());
        return Ok(values);
    }
}
