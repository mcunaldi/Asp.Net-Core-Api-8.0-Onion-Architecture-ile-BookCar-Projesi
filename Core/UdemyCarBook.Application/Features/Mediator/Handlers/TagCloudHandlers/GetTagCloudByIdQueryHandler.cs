using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository) : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
{
    public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetTagCloudByIdQueryResult
        {
            TagCloudId = value.TagCloudId,
            Title = value.Title,
            BlogId = value.TagCloudId
        };
    }
}
