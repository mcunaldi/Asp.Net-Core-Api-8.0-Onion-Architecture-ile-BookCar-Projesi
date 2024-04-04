using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public class RemoveAboutCommandHandler(
    IRepository<About> repository)
{
    public async Task Handle(RemoveAboutCommand command)
    {
        var value = await repository.GetByIdAsync(command.Id);
        await repository.RemoveAsync(value);
    }
}
