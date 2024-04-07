using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public class CreateBlogCommandHandler(IRepository<Blog> repository) : IRequestHandler<CreateBlogCommand>
{
    public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Blog()
        {
            AuthorID = request.AuthorID,
            CategoryID = request.CategoryID,
            CoverImageUrl = request.CoverImageUrl,
            CreatedDate = request.CreatedDate,
            Title = request.Title
        });
    }
}
