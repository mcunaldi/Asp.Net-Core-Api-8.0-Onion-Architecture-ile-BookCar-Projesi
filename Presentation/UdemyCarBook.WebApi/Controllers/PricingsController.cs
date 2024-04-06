using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.PricingCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PricingsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> PricingList()
    {
        var values = await mediator.Send(new GetPricingQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> PricingList(int id)
    {
        var value = await mediator.Send(new GetPricingByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePricing(CreatePricingCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Ödeme türü başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeletePricing(int id)
    {
        await mediator.Send(new RemovePricingCommand(id));
        return Ok("Ödeme türü başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Ödeme türü başarıyla güncellendi.");
    }
}
