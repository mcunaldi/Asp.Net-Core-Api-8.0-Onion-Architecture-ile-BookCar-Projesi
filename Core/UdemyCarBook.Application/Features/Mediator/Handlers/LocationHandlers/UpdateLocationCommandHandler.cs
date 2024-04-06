using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.LocationHandlers;
public class UpdateLocationCommandHandler(IRepository<Location> repository) : IRequestHandler<UpdateLocationCommand>
{
    public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.LocationID);
        value.Name = request.Name;
        await repository.UpdateAsync(value);
    }
}
