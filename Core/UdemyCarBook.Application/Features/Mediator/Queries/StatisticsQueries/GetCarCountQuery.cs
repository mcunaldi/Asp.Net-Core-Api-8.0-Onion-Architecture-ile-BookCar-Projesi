using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
public class GetCarCountQuery : IRequest<GetCarCountQueryResult>
{
}
