using UdemyCarBook.Application.Features.CQRS.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class GetContactQueryHandler(IRepository<Contact> repository)
{
    public async Task<List<GetContactQueryResult>> Handle()
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetContactQueryResult
        {
            ContactID = x.ContactID,
            Name = x.Name,
            Email = x.Email,
            Message = x.Message,
            Subject = x.Subject,
            SendDate = x.SendDate
        }).ToList();
    }
}
