using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces.CarInterfaces;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
{
    public List<GetLast5CarsWithBrandsQueryResult> Handle()
    {
        var values = repository.GetLast5CarsWithBrands();
        return values.Select(x => new GetLast5CarsWithBrandsQueryResult
        {
            BrandName = x.Brand.Name,
            BrandID = x.BrandID,
            BigImageUrl = x.BigImageUrl,
            CoverImageUrl = x.CoverImageUrl,
            CarID = x.CarID,
            Transmission = x.Transmission,
            Fuel = x.Fuel,
            Seat = x.Seat,
            Model = x.Model,
            Luggage = x.Luggage,
            Km = x.Km
        }).ToList();
    }
}
