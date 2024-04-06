using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SocialMediasController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> SocialMediaList()
    {
        var values = await mediator.Send(new GetSocialMediaQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> SocialMediaList(int id)
    {
        var value = await mediator.Send(new GetSocialMediaByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Sosyal medya başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteSocialMedia(int id)
    {
        await mediator.Send(new RemoveSocialMediaCommand(id));
        return Ok("Sosyal medya başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Sosyal medya başarıyla güncellendi.");
    }
}
