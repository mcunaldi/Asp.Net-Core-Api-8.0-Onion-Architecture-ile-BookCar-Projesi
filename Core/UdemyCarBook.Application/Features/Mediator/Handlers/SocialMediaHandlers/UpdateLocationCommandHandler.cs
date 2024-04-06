using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;
public class UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository) : IRequestHandler<UpdateSocialMediaCommand>
{
    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.SocialMediaID);
        value.Icon = request.Icon;
        value.Url = request.Url;
        value.Name = request.Name;
        await repository.UpdateAsync(value);
    }
}