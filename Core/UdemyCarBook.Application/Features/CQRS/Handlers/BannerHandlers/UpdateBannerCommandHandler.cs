﻿using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class UpdateBannerCommandHandler(IRepository<Banner> repository)
{
    public async Task Handle(UpdateBannerCommand command)
    {
        var values = await repository.GetByIdAsync(command.BannerID);
        values.Description = command.Description;
        values.Title = command.Title;
        values.VideoUrl = command.VideoUrl;
        values.VideoDescription = command.VideoDescription;
        await repository.UpdateAsync(values);
    }
}
