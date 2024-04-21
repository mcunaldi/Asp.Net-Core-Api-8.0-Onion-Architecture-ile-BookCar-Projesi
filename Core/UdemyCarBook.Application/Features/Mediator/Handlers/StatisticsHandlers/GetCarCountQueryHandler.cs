using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.CarInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetCarCountQueryHandler(ICarRepository carRepository) : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
{
    public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
    {
        var value = carRepository.GetCarCount();
        return new GetCarCountQueryResult
        {
            CarCount = value
        };
    }
}
