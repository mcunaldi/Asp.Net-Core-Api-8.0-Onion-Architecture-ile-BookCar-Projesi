using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
{
    public int Id { get; set; }

    public GetTagCloudByIdQuery(int id)
    {
        Id = id;
    }
}
