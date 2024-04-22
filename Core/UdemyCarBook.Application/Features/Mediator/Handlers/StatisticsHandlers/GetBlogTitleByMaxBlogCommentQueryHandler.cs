using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetBlogTitleByMaxBlogCommentQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, GetBlogTitleByMaxBlogCommentQueryResult>
{
    public async Task<GetBlogTitleByMaxBlogCommentQueryResult> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetBlogTitleByMaxBlogComment();
        return new GetBlogTitleByMaxBlogCommentQueryResult
        {
            BlogTitleByMaxBlogComment = value
        };
    }
}
