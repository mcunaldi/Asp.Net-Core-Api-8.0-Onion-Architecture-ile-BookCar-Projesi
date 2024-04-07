using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public class RemoveBlogCommandHandler(IRepository<Blog> repository) : IRequestHandler<RemoveBlogCommand>
{
    public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        await repository.RemoveAsync(value);
    }
}
