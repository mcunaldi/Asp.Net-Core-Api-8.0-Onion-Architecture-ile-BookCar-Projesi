using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;
using UdemyCarBook.Application.Features.Mediator.Results.AuthorResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AuthorHandlers;
public class GetAuthorQueryHandler(IRepository<Author> repository) : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
{
    public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetAuthorQueryResult()
        {
            AuthorID = x.AuthorID,
            Name = x.Name,
            Description = x.Description,
            ImageUrl = x.ImageUrl
        }).ToList();
    }
}
