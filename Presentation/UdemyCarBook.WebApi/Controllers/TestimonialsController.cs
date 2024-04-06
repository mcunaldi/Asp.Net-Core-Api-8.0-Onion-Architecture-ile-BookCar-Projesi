using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestimonialsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> TestimonialList()
    {
        var values = await mediator.Send(new GetTestimonialQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> TestimonialList(int id)
    {
        var value = await mediator.Send(new GetTestimonialByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Referans başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        await mediator.Send(new RemoveTestimonialCommand(id));
        return Ok("Referans başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Referans başarıyla güncellendi.");
    }
}
