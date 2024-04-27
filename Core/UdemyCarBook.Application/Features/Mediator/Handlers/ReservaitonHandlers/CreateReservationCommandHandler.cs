using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.ReservationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservaitonHandlers;
public class CreateReservationCommandHandler(IRepository<Reservation> repository) : IRequestHandler<CreateReservationCommand>
{
    public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Reservation()
        {
            Name = request.Name,
            Age = request.Age,
            CarID = request.CarID,
            Description = request.Description,
            DriverLicenseYear = request.DriverLicenseYear,
            DropOffLocationID = request.DropOffLocationID,
            Email = request.Email,
            Phone = request.Phone,
            PickUpLocationID = request.PickUpLocationID,  
            Surname = request.Surname,
            Status = "Rezervasyon Alındı"
        });
    }
}
