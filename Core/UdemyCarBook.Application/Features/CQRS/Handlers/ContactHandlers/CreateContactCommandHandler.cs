using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class CreateContactCommandHandler(IRepository<Contact> repository)
{
    public async Task Handle(CreateContactCommand command)
    {
        await repository.CreateAsync(new Contact
        {
            Name = command.Name,
            Message = command.Message,
            Email = command.Email,
            SendDate = command.SendDate,
            Subject  = command.Subject
        });
    }
}
