using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.LocationHandlers;
public class CreateLocationCommandHandler(IRepository<Location> repository) : IRequestHandler<CreateLocationCommand>
{
    public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Location()
        {
            Name = request.Name,
        });
    }
}
