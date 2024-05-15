using MediatR;
using UdemyCarBook.Application.Enums;
using UdemyCarBook.Application.Features.Mediator.Commands.AppUserCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers;
public class CreateAppUserCommandHandler(IRepository<AppUser> repository) : IRequestHandler<CreateAppUserCommand>
{
    public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new AppUser
        {
            Username = request.Username,
            Password = request.Password,
            AppRoleID = (int)RoleTypes.Member,
            Name = request.Name,
            Surname = request.Surname,
            Email = request.Email
        });
    }
}
