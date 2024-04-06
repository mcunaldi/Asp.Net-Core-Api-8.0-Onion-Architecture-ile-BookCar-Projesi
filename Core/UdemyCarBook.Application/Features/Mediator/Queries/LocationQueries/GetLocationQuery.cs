using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.LocationResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries;
public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
{
}
