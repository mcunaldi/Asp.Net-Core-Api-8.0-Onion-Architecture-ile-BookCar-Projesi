using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.ReservationCommands;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ReservationsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateReservation(CreateReservationCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Rezervasyon başarıyla eklendi.");
    }

}
