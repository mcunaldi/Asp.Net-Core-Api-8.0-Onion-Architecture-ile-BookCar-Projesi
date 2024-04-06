using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;
public class CreateSocialMediaHandlers(IRepository<SocialMedia> repository) : IRequestHandler<CreateSocialMediaCommand>
{
    public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new SocialMedia
        {
            Icon = request.Icon,
            Name = request.Name,
            Url = request.Url
        });
    }
}
