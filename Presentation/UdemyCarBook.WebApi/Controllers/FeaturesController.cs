using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FeaturesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FeatureList()
    {
        var values = await mediator.Send(new GetFeatureQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> FeatureList(int id)
    {
        var value = await mediator.Send(new GetFeatureByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateFeature(CreateFeatureCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Özellik başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteFeature(int id)
    {
        await mediator.Send(new RemoveFeatureCommand(id));
        return Ok("Özellike başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Özellik başarıyla güncellendi.");
    }
}
