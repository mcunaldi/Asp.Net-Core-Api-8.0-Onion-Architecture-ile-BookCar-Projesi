using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarFeatureResults;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;
public class GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository) : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
{
    public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
    {
        var values = repository.GetCarFeaturesByCarId(request.Id);
        return values.Select(x => new GetCarFeatureByCarIdQueryResult
        {
            Available = x.Available,
            CarFeatureID = x.CarFeatureID,
            FeatureID = x.FeatureID
        }).ToList();
    }
}
