using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.ServiceResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.ServiceQueries;
public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
{
}
