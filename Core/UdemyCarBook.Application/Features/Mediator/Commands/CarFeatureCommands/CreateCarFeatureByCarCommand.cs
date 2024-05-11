using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
public class CreateCarFeatureByCarCommand : IRequest
{
    public int CarID { get; set; }
    public int FeatureID { get; set; }
}
