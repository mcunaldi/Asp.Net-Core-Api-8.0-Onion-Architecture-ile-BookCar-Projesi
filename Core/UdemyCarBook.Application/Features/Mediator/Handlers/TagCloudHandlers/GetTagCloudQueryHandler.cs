using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class GetTagCloudQueryHandler(IRepository<TagCloud> repository) : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
{
    public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetTagCloudQueryResult()
        {
            TagCloudId = x.TagCloudId,
            Title = x.Title,
            BlogId = x.BlogId
        }).ToList();
    }
}
