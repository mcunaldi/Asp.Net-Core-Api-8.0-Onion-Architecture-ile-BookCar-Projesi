using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public class GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository) : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
{
    public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
    {
        var values = repository.GetLast3BlogsWithAuthors();
        return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
        {
            AuthorID = x.AuthorID,
            AuthorName = x.Author.Name,
            BlogID = x.BlogID,
            CategoryID = x.CategoryID,
            CoverImageUrl = x.CoverImageUrl,
            CreatedDate = x.CreatedDate,
            Title = x.Title
        }).ToList();
    }
}
