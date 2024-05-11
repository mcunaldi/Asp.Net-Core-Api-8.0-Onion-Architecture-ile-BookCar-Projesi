using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;
public class UpdateCarFeatureAvailableChangeToTrueCommandHandler(ICarFeatureRepository carFeatureRepository) : IRequestHandler<UpdateCarFeatureAvailableChangeToTrueCommand>
{
    public async Task Handle(UpdateCarFeatureAvailableChangeToTrueCommand request, CancellationToken cancellationToken)
    {
        carFeatureRepository.ChangeCarFeatureAvailableToTrue(request.Id);
    }
}
