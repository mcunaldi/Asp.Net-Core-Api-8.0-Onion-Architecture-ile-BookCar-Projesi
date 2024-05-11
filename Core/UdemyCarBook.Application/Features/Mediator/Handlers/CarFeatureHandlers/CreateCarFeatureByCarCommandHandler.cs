using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;
public class CreateCarFeatureByCarCommandHandler(ICarFeatureRepository carFeatureRepository) : IRequestHandler<CreateCarFeatureByCarCommand>
{
    public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
    {
        carFeatureRepository.CreateCarFeatureByCar(new CarFeature()
        {
            Available = false,
            CarID = request.CarID,
            FeatureID = request.FeatureID
        });
    }
}
