using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetAvgRentPriceForWeeklyQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetAvgRentPriceForWeeklyQuery, GetAvgRentPriceForWeeklyQueryResult>
{
    public async Task<GetAvgRentPriceForWeeklyQueryResult> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetAvgRentPriceForWeekly();
        return new GetAvgRentPriceForWeeklyQueryResult
        {
            AvgRentPriceForWeekly = value
        };
    }
}