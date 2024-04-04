using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AboutsController(
    CreateAboutCommandHandler createAboutCommandHandler,
    GetAboutByIdQueryHandler getAboutByIdQueryHandler,
    GetAboutQueryHandler getAboutQueryHandler,
    UpdateAboutCommandHandler updateAboutCommandHandler,
    RemoveAboutCommandHandler removeAboutCommandHandler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> AboutList()
    {
        var values = await getAboutQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAbout(int id)
    {
        var value = await getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
    {
        await createAboutCommandHandler.Handle(command);
        return Ok("Hakkında bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAbout(int id)
    {
        await removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
        return Ok("Hakkımda bilgisi silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
    {
        await updateAboutCommandHandler.Handle(command);
        return Ok("Hakkımda bilgisi güncellendi.");
    }
}
