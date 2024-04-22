using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
internal class GetAvgRentPriceForMonthlyQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetAvgRentPriceForMonthlyQuery, GetAvgRentPriceForMonthlyQueryResult>
{
    public async Task<GetAvgRentPriceForMonthlyQueryResult> Handle(GetAvgRentPriceForMonthlyQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetAvgRentPriceForMonthly();
        return new GetAvgRentPriceForMonthlyQueryResult
        {
            AvgRentPriceForMonthly = value
        };
    }
}
