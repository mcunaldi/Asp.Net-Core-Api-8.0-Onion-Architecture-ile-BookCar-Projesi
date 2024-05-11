using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.CarFeatureQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarFeaturesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> CarFeatureListByCarId(int id)
    {
        var values = await mediator.Send(new GetCarFeatureByCarIdQuery(id));
        return Ok(values);
    }

    [HttpGet("CarFeatureChangeAvailableToFalse")]
    public async Task<IActionResult> CarFeatureChangeAvailableToFalse(int id)
    {
        mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
        return Ok("Güncelleme yapıldı.");
    }

    [HttpGet("CarFeatureChangeAvailableToTrue")]
    public async Task<IActionResult> CarFeatureChangeAvailableToTrue(int id)
    {
        mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
        return Ok("Güncelleme yapıldı.");
    }
}
