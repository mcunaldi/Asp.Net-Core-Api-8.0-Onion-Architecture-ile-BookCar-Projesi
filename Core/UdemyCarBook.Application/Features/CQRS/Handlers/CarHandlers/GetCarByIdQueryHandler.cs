using UdemyCarBook.Application.Features.CQRS.Queries.CarQueries;
using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarByIdQueryHandler(IRepository<Car> repository)
{
    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var values = await repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult
        {
            BrandID = values.BrandID,
            BigImageUrl = values.BigImageUrl,
            CoverImageUrl = values.CoverImageUrl,
            CarID = values.CarID,
            Transmission = values.Transmission,
            Fuel = values.Fuel,
            Seat = values.Seat,
            Model = values.Model,
            Luggage = values.Luggage,
            Km = values.Km
        };
    }
}
