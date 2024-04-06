using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FooterAddressesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var values = await mediator.Send(new GetFooterAddressQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetListById(int id)
    {
        var values = await mediator.Send(new GetFooterAddressByIdQuery(id));
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command, cancellation);
        return Ok("Alt Adres bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveFooterAddress(int id)
    {
        await mediator.Send(new GetFooterAddressByIdQuery(id));
        return Ok("Alt Adres bilgisi silindi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command, cancellation);
        return Ok("Alt Adres bilgisi güncellendi.");
    }
}
