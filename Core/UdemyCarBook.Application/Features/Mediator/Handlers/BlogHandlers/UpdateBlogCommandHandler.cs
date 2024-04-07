using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public class UpdateBlogCommandHandler(IRepository<Blog> repository) : IRequestHandler<UpdateBlogCommand>
{
    public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.BlogID);
        value.AuthorID = request.AuthorID;
        value.CreatedDate = request.CreatedDate;
        value.CategoryID = request.CategoryID;
        value.CoverImageUrl = request.CoverImageUrl;
        value.Title = request.Title;
        await repository.UpdateAsync(value);
    }
}
