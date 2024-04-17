using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
{
}
