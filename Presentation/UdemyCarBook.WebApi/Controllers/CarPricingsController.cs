using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarPricingsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCarPricingWithCarQueryList()
    {
        var values = await mediator.Send(new GetCarPricingWithCarQuery());
        return Ok(values);
    }
}
