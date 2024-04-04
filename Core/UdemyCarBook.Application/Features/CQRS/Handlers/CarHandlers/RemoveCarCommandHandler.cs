using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class RemoveCarCommandHandler(IRepository<Car> repository)
{
    public async Task Handle(RemoveCarCommand command)
    {
        var value = await repository.GetByIdAsync(command.Id);
        await repository.RemoveAsync(value);
    }
}
