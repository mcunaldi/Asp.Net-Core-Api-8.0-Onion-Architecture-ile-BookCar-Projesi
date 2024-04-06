using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ServiceHandlers;
public class UpdateServiceCommandHandler(IRepository<Service> repository) : IRequestHandler<UpdateServiceCommand>
{
    public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.ServiceID);
        value.Description = request.Description;
        value.Title = request.Title;
        value.IconUrl = request.IconUrl;
        await repository.UpdateAsync(value);
    }
}
