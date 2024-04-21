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
}
