using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.AuthorResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;
public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
{
}
