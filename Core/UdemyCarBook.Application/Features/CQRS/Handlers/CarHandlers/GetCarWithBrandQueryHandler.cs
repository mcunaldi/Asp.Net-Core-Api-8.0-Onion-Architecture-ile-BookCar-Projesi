using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarWithBrandQueryHandler(ICarRepository repository)
{
    public List<GetCarWithBrandQueryResult> Handle()
    {
        var values = repository.GetCarsListWithBrands();
        return values.Select(x => new GetCarWithBrandQueryResult
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
