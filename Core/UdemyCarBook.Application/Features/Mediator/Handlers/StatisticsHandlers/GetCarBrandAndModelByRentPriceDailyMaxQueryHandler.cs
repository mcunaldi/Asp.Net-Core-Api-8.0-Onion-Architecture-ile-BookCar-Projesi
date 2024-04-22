using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetCarBrandAndModelByRentPriceDailyMaxQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMaxQuery, GetCarBrandAndModelByRentPriceDailyMaxQueryResult>
{
    public async Task<GetCarBrandAndModelByRentPriceDailyMaxQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetCarBrandAndModelByRentPriceDailyMax();
        return new GetCarBrandAndModelByRentPriceDailyMaxQueryResult
        {
            CarBrandAndModelByRentPriceDailyMax = value
        };
    }
}
