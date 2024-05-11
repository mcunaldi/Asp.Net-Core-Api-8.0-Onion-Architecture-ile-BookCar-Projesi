using MediatR;
using Microsoft.AspNetCore.Mvc;
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
}
