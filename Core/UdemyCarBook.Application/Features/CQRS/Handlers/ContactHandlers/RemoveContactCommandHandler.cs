using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class RemoveContactCommandHandler(IRepository<Contact> repository)
{
    public async Task Handle(RemoveContactCommand command)
    {
        var value = await repository.GetByIdAsync(command.Id);
        await repository.RemoveAsync(value);
    }
}
