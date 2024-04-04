using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class RemoveBannerCommandHandler(IRepository<Banner> repository)
{
    public async Task Handle(RemoveBannerCommand command)
    {
        var value = await repository.GetByIdAsync(command.Id);
        await repository.RemoveAsync(value);
    }
}
