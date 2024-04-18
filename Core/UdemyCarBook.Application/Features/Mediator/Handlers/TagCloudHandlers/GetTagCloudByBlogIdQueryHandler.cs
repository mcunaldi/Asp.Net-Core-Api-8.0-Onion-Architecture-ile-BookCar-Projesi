using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
{
    private readonly ITagCloudRepository _repository;

    public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetTagCloudByBlogID(request.Id);
        return values.Select(x => new GetTagCloudByBlogIdQueryResult
        {
            TagCloudId = x.TagCloudId,
            BlogId = x.BlogId,
            Title  = x.Title
        }).ToList();
    }
}
