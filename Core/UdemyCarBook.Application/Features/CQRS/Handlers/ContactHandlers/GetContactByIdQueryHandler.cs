using UdemyCarBook.Application.Features.CQRS.Queries.ContactQueries;
using UdemyCarBook.Application.Features.CQRS.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public class GetContactByIdQueryHandler(IRepository<Contact> repository)
{
    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var values = await repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            ContactID = values.ContactID,
            Name = values.Name,
            Email = values.Email,
            SendDate = values.SendDate,
            Subject = values.Subject,
            Message = values.Message
        };
    }
}
