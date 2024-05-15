using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.AppUserQueries;
using UdemyCarBook.Application.Features.Mediator.Results.AppUserResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers;
public class GetCheckAppUserQueryHandler(
    IRepository<AppUser> appUserRepository,
    IRepository<AppRole> appRoleRepository) : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
{    
    public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
    {
        var values = new GetCheckAppUserQueryResult();
        var user = await appUserRepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
        if (user is null)
        {
            values.IsExist = false;
        }
        else
        {
            values.IsExist = true;
            values.Username = user.Username;
            values.Role = (await appRoleRepository.GetByFilterAsync(x=> x.AppRoleID == user.AppRoleID)).AppRoleName;
            values.Id = user.AppUserID;
        }
            return values;
    }
}
