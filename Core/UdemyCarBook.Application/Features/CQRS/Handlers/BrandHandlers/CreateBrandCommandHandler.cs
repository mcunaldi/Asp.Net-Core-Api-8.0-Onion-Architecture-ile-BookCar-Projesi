using UdemyCarBook.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
public class CreateBrandCommandHandler(IRepository<Brand> repository)
{
    public async Task Handle(CreateBrandCommand command)
    {
        await repository.CreateAsync(new Brand
        {
            Name = command.Name,
        });
    }
}
