using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarDescriptionHandlers;
public class GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository) : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQueryResult>
{
    public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetCarDescription(request.Id);
        return new GetCarDescriptionQueryResult
        {
            CarID = value.CarID,
            CarDescriptionID = value.CarDescriptionID,
            Details = value.Details
        };
    }
}
