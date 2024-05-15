using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.AppUserCommands;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RegisterController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateAppUserCommand command)
    {
        await mediator.Send(command);
        return Ok("Kullanıcı başarıyla oluşturuldu.");
    }
}
