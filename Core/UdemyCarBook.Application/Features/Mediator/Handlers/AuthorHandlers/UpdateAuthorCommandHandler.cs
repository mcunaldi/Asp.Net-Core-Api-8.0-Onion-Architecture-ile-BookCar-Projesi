using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AuthorHandlers;
public class UpdateAuthorCommandHandler(IRepository<Author> repository) : IRequestHandler<UpdateAuthorCommand>
{
    public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.AuthorID);
        value.Name = request.Name;
        value.Description = request.Description;
        value.ImageUrl = request.ImageUrl;
        await repository.UpdateAsync(value);
    }
}
