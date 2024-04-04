using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
public class CreateCategoryCommandHandler(IRepository<Category> repository)
{
    public async Task Handle(CreateCategoryCommand command)
    {
        await repository.CreateAsync(new Category
        {
            Name = command.Name,
        });
    }
}