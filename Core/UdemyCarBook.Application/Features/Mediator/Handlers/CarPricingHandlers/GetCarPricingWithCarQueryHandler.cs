using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces.CarPricingInterface;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;
public class GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository) : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
{
    public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
    {
        var values = carPricingRepository.GetCarPricingWithCars();
        return values.Select(x=> new GetCarPricingWithCarQueryResult
        {
            Amount = x.Amount,
            Brand =  x.Car.Brand.Name,
            CarPricingID = x.CarPricingID,
            CoverImageUrl = x.Car.CoverImageUrl,
            Model = x.Car.Model,
            CarID = x.Car.CarID
        }).ToList();
    }
}
