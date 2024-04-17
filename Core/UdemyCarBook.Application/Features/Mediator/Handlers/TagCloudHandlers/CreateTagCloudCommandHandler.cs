using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class CreateTagCloudCommandHandler(IRepository<TagCloud> repository) : IRequestHandler<CreateTagCloudCommand>
{
    public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new TagCloud()
        {
            Title = request.Title,
            BlogId = request.BlogId
        });
    }
}
