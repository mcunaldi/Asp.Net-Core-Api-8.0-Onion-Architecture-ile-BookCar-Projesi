using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetCarBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMinQuery, GetCarBrandAndModelByRentPriceDailyMinQueryResult>
{
    public async Task<GetCarBrandAndModelByRentPriceDailyMinQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetCarBrandAndModelByRentPriceDailyMin();
        return new GetCarBrandAndModelByRentPriceDailyMinQueryResult
        {
            CarBrandAndModelByRentPriceDailyMin = value
        };
    }
}
