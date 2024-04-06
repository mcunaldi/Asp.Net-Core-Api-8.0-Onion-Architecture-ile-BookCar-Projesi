using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FeatureHandlers;
public class GetFeatureByIdQueryHandler(IRepository<Feature> repository) : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
{
    public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await repository.GetByIdAsync(request.Id);
        return new GetFeatureByIdQueryResult
        {
            FeatureID = values.FeatureID,
            Name = values.Name
        };
    }
}
