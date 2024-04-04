using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class CreateCarCommandHandler(IRepository<Car> repository)
{
    public async Task Handle(CreateCarCommand command)
    {
        await repository.CreateAsync(new Car
        {
            BigImageUrl = command.BigImageUrl,
            Km = command.Km,
            Luggage = command.Luggage,
            Model = command.Model,
            Seat = command.Seat,
            Fuel = command.Fuel,
            Transmission = command.Transmission,
            CoverImageUrl = command.CoverImageUrl,
            BrandID = command.BrandID
        });
    }
}
