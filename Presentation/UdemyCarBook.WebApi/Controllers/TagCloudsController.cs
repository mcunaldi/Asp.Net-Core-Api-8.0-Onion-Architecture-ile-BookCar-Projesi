using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TagCloudsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> TagCloudList()
    {
        var values = await mediator.Send(new GetTagCloudQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> TagCloudList(int id)
    {
        var value = await mediator.Send(new GetTagCloudByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Etiketler başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteTagCloud(int id)
    {
        await mediator.Send(new RemoveTagCloudCommand(id));
        return Ok("Etiketler başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Etiketler başarıyla güncellendi.");
    }
}
