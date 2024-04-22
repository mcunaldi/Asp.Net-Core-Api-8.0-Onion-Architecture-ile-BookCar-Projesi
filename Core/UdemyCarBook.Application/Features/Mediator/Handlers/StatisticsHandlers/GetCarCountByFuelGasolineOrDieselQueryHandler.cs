using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetCarCountByFuelGasolineOrDieselQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, GetCarCountByFuelGasolineOrDieselQueryResult>
{
    public async Task<GetCarCountByFuelGasolineOrDieselQueryResult> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetCarCountByFuelGasolineOrDiesel();
        return new GetCarCountByFuelGasolineOrDieselQueryResult
        {
            CarCountByFuelGasolineOrDiesel = value
        };
    }
}
