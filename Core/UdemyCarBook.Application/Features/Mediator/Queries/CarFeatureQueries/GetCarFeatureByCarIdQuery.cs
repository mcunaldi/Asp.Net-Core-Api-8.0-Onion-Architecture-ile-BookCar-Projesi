using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.CarFeatureResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
public class GetCarFeatureByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
{
    public int Id { get; set; }
    public GetCarFeatureByCarIdQuery(int id)
    {
        Id = id;
    }
}
