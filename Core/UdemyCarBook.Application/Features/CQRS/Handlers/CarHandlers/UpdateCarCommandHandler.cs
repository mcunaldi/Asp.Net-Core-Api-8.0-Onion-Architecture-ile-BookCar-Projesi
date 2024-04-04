using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
public class UpdateCarCommandHandler(IRepository<Car> repository)
{
    public async Task Handle(UpdateCarCommand command)
    {
        var value = await repository.GetByIdAsync(command.CarID);
        value.Fuel = command.Fuel;
        value.Transmission = command.Transmission;
        value.BigImageUrl = command.BigImageUrl;
        value.CoverImageUrl = command.CoverImageUrl;
        value.BrandID = command.BrandID;
        value.Km = command.Km;
        value.Luggage = command.Luggage;
        value.Model = command.Model;
        value.Seat = command.Seat;
        await repository.UpdateAsync(value);
    }
}
