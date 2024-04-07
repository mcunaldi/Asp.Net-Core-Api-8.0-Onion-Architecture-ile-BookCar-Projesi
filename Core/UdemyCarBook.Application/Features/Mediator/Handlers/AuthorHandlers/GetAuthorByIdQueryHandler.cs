using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;
using UdemyCarBook.Application.Features.Mediator.Results.AuthorResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AuthorHandlers;
public class GetAuthorByIdQueryHandler(IRepository<Author> repository) : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
{
    public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetAuthorByIdQueryResult
        {
            AuthorID = value.AuthorID,
            Name  = value.Name,
            Description = value.Description,
            ImageUrl = value.ImageUrl
        };
    }
}
