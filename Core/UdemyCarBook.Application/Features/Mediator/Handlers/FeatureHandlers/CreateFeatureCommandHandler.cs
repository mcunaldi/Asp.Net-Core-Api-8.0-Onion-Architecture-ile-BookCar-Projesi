using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FeatureHandlers;
public class CreateFeatureCommandHandler(IRepository<Feature> repository) : IRequestHandler<CreateFeatureCommand>
{
    public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
    {
            await repository.CreateAsync(new Feature
            {
                Name = request.Name,
            });
    }
}
