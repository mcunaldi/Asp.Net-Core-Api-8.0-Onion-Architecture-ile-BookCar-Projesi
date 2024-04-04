using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
public class UpdateCategoryCommandHandler(IRepository<Category> repository)
{
    public async Task Handle(UpdateCategoryCommand command)
    {
        var value = await repository.GetByIdAsync(command.CategoryID);
        value.Name = command.Name;
        await repository.UpdateAsync(value);
    }
}
