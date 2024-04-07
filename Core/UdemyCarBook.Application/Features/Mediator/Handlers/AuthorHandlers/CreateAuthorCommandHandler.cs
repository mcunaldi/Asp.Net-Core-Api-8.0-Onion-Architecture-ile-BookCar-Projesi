using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AuthorHandlers;
public class CreateAuthorCommandHandler(IRepository<Author> repository) : IRequestHandler<CreateAuthorCommand>
{
    public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Author()
        {
            Name = request.Name,
            ImageUrl = request.ImageUrl,
            Description = request.Description
        });
    }
}
