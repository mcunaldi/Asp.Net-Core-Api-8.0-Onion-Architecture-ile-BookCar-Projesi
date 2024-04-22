using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetCarCountBySmallerThan1000QueryHandler(IStatisticsRepository repository) : IRequestHandler<GetCarCountBySmallerThan1000Query, GetCarCountBySmallerThan1000QueryResult>
{
    public async Task<GetCarCountBySmallerThan1000QueryResult> Handle(GetCarCountBySmallerThan1000Query request, CancellationToken cancellationToken)
    {
        var value = repository.GetCarCountBySmallerThan1000();
        return new GetCarCountBySmallerThan1000QueryResult
        {
            CarCountBySmallerThan1000 = value
        };
    }
}
