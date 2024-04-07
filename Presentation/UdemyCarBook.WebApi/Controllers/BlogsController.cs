using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BlogsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> BlogList()
    {
        var values = await mediator.Send(new GetBlogQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BlogList(int id)
    {
        var value = await mediator.Send(new GetBlogByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog(CreateBlogCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Blog başarıyla eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteBlog(int id)
    {
        await mediator.Send(new RemoveBlogCommand(id));
        return Ok("Blog başarıyla silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Blog başarıyla güncellendi.");
    }

    [HttpGet("GetLast3BlogsWithAuthorsList")]
    public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
    {
        var value = await mediator.Send(new GetLast3BlogsWithAuthorsQuery());
        return Ok(value);
    }
}
