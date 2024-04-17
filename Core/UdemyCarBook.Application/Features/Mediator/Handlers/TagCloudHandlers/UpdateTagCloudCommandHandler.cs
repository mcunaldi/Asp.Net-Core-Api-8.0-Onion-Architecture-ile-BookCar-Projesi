using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class UpdateTagCloudCommandHandler(IRepository<TagCloud> repository) : IRequestHandler<UpdateTagCloudCommand>
{
    public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.TagCloudId);
        value.Title = request.Title;
        value.BlogId = request.BlogId;
        await repository.UpdateAsync(value);
    }
}
