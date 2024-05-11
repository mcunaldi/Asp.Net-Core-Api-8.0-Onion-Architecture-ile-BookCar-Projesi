using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.CommentCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.ReservationCommands;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CommentsController(
    IGenericRepository<Comment> repository,
    IMediator mediator) : ControllerBase
{
    [HttpGet]
    public IActionResult CommentList()
    {
        var values = repository.GetAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult CreateComment(Comment comment)
    {
        repository.Create(comment);
        return Ok("Yorum başarıyla oluşturuldu.");
    }

    [HttpDelete]
    public IActionResult RemoveComment(int id)
    {
        var value = repository.GetById(id);
        repository.Remove(value);
        return Ok("Yorum başarıyla silindi.");
    }

    [HttpPut]
    public IActionResult UpdateComment(Comment comment)
    {
        repository.Update(comment);
        return Ok("Yorum başarıyla oluşturuldu.");
    }

    [HttpGet("{id}")]
    public IActionResult GetComment(int id)
    {
        var value = repository.GetById(id);
        return Ok(value);
    }

    [HttpGet("CommentListByBlog")]
    public IActionResult CommentListByBlog(int id)
    {
        var value = repository.GetCommentByBlogId(id);
        return Ok(value);
    }

    [HttpGet("CommentCountByBlog")]
    public IActionResult CommentCountByBlog(int id)
    {
        var value = repository.GetCountCommentByBlog(id);
        return Ok(value);
    }


    [HttpPost("CreateCommandWithMediator")]
    public async Task<IActionResult> CreateReservation(CreateCommentCommand command, CancellationToken cancellation)
    {
        await mediator.Send(command);
        return Ok("Yorum başarıyla eklendi.");
    }

}
