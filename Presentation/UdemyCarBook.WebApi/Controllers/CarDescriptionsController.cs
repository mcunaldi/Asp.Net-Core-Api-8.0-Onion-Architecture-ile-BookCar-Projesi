using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarDescriptionsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> CarDescriptionByCarId(int carId)
    {
        var values = await mediator.Send(new GetCarDescriptionByCarIdQuery(carId));
        return Ok(values);
    }
}
