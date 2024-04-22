using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetLocationCountQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
{
    public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetLocationCount();
        return new GetLocationCountQueryResult
        {
            LocationCount = value
        };
    }
}
