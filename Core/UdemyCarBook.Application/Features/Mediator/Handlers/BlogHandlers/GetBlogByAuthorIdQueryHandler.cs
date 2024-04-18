using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public class GetBlogByAuthorIdQueryHandler(IBlogRepository blogRepository) : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
{
    public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
    {
        var values  = blogRepository.GetBlogByAuthorId(request.Id);
        return values.Select(x => new GetBlogByAuthorIdQueryResult
        {
            AuthorID = x.AuthorID,
            BlogID = x.BlogID,
            AuthorName = x.Author.Name,
            AuthorDescription = x.Author.Description,
            AuthorImageUrl = x.Author.ImageUrl
        }).ToList();
    }
}
