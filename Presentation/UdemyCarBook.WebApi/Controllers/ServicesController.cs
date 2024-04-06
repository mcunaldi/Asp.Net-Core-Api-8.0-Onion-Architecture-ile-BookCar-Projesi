using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.ServiceQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServicesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> ServiceList()
    {
        var values = await mediator.Send(new GetServiceQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ServiceList(int id)
    {
        var value = await mediator.Send(new GetServiceByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateService(CreateServiceCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Servis türü başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteService(int id)
    {
        await mediator.Send(new RemoveServiceCommand(id));
        return Ok("Servis türü başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateService(UpdateServiceCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Servis türü başarıyla güncellendi.");
    }
}
