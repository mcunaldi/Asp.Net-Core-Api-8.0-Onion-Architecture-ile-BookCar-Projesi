using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries;

namespace UdemyCarBook.WebApi.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/[controller]")]
[ApiController]
public class LocationsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> LocationList()
    {
        var values = await mediator.Send(new GetLocationQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> LocationList(int id)
    {
        var value = await mediator.Send(new GetLocationByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateLocation(CreateLocationCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Lokasyon başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteLocation(int id)
    {
        await mediator.Send(new RemoveLocationCommand(id));
        return Ok("Lokasyon başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Lokasyon başarıyla güncellendi.");
    }
}
