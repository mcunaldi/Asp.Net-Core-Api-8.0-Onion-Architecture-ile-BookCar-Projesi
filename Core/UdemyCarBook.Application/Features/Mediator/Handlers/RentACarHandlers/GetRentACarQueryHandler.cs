using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.RentACarQueries;
using UdemyCarBook.Application.Features.Mediator.Results.RentACarResults;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler(IRentACarRepository repository) : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == request.Available);
            var results = values.Select(x => new GetRentACarQueryResult()
            {
                CarID = x.CarID,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model,
                CoverImageUrl = x.Car.CoverImageUrl
            }).ToList();

            return results;
        }
    }
}