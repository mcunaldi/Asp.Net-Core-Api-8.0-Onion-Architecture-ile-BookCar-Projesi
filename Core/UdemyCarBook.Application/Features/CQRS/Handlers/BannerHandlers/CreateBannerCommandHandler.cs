using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class CreateBannerCommandHandler(IRepository<Banner> repository)
{
    public async Task Handle(CreateBannerCommand command)
    {
        await repository.CreateAsync(new Banner
        {
           Description = command.Description,
           Title = command.Title,
           VideoDescription = command.VideoDescription,
           VideoUrl = command.VideoUrl
        });
    }
}
