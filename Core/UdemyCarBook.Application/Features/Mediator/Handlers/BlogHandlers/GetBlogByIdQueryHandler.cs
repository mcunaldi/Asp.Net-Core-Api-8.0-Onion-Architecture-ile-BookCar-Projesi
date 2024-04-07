using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public class GetBlogByIdQueryHandler(IRepository<Blog> repository) : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
{
    public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetBlogByIdQueryResult
        {
            AuthorID = value.AuthorID,
            CategoryID = value.CategoryID,
            CoverImageUrl = value.CoverImageUrl,
            CreatedDate = value.CreatedDate,
            Title = value.Title
        };
    }
}
