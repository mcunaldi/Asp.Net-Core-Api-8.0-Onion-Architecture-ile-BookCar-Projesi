using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public class UpdateAboutCommandHandler(IRepository<About> repository)
{
    public async Task Handle(UpdateAboutCommand command)
    {
        var values = await repository.GetByIdAsync(command.AboutID);
        values.Description = command.Description;
        values.Title = command.Title;
        values.ImageUrl = command.ImageUrl;
        await repository.UpdateAsync(values);
    }
}
