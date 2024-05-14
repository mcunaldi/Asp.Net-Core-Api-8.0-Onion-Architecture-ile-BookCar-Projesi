using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReviewHandlers;
public class UpdateReviewCommandHandler(IRepository<Review> repository) : IRequestHandler<UpdateReviewCommand>
{
    public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.ReviewID);
        value.CustomerName = request.CustomerName;
        value.Comment = request.Comment;
        value.ReviewDate = request.ReviewDate;
        value.CarID = request.CarID;
        value.ReviewID = request.ReviewID;
        value.RaytingValue = request.RaytingValue;
        await repository.UpdateAsync(value);
    }
}
