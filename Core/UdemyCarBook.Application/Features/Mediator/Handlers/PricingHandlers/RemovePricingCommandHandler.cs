using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.PricingCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers;
public class RemovePricingCommandHandler(IRepository<Pricing> repository) : IRequestHandler<RemovePricingCommand>
{
    public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        await repository.RemoveAsync(value);
    }
}
