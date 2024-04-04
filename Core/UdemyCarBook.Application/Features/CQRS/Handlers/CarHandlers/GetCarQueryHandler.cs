using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarQueryHandler(IRepository<Car> repository)
{
    public async Task<List<GetCarQueryResult>> Handle()
    {
        var values = await repository.GetAllAsync();
        return values.Select(x=> new GetCarQueryResult
        {
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
