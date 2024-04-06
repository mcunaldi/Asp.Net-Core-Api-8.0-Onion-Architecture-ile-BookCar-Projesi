using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.PricingCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers;
public class UpdatePricingCommandHandler(IRepository<Pricing> repository) : IRequestHandler<UpdatePricingCommand>
{
    public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.PricingID);
        value.Name = request.Name;
        await repository.UpdateAsync(value);
    }
}
