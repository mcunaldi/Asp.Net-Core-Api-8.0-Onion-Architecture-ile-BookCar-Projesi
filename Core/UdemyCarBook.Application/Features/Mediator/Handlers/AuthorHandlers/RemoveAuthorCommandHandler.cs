using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AuthorHandlers;
public class RemoveAuthorCommandHandler(IRepository<Author> repository) : IRequestHandler<RemoveAuthorCommand>
{
    public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        await repository.RemoveAsync(value);
    }
}
