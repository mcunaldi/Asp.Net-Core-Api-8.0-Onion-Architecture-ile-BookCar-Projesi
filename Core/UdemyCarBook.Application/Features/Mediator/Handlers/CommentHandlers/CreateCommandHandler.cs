using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.CommentCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CommentHandlers;
public class CreateCommandHandler(IRepository<Comment> repository) : IRequestHandler<CreateCommentCommand>
{
    public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Comment()
        {
            BlogID = request.BlogID,
            Description = request.Description,
            CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
            Name = request.Name,
            Email = request.Email,

        });
    }
}
