using UdemyCarBook.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
public class RemoveBrandCommandHandler(IRepository<Brand> repository)
{
    public async Task Handle(RemoveBrandCommand command)
    {
        var value = await repository.GetByIdAsync(command.Id);
        await repository.RemoveAsync(value);
    }
}
