using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class UpdateContactCommandHandler(IRepository<Contact> repository)
{
    public async Task Handle(UpdateContactCommand command)
    {
        var value = await repository.GetByIdAsync(command.ContactID);
        value.Name = command.Name;
        value.Email = command.Email;
        value.SendDate = command.SendDate;
        value.Message = command.Message;
        value.Subject = command.Subject;
        await repository.UpdateAsync(value);
    }
}
