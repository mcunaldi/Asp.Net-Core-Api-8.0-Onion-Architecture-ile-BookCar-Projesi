using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public class UpdateFooterCommandHandler(IRepository<FooterAddress> repository) : IRequestHandler<UpdateFooterAddressCommand>
{
    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.FooterAddressID);
        value.PhoneNumber = request.PhoneNumber;
        value.Address = request.Address;
        value.Description = request.Description;
        value.Email = request.Email;
        await repository.UpdateAsync(value);
    }
}
