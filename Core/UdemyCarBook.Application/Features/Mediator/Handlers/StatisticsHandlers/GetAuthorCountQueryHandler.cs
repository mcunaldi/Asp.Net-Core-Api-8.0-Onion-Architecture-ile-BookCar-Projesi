using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetAuthorCountQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
{
    public async Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetAuthorCount();
        return new GetAuthorCountQueryResult
        {
            AuthorCount = value
        };
    }
}
