using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public class CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository) : IRequestHandler<CreateFooterAddressCommand>
{
    public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new FooterAddress()
        {
            Address = request.Address,
            Description = request.Description,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        });
    }
}
