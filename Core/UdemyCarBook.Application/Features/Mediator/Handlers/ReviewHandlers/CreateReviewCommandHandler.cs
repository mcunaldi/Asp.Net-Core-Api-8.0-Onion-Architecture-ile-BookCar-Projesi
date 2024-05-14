using FluentValidation;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.ReviewInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReviewHandlers;
public class CreateReviewCommandHandler(
    IRepository<Review> repository) : IRequestHandler<CreateReviewCommand>
{
    public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Review()
        {
            CustomerImage = request.CustomerImage,
            CustomerName = request.CustomerName,    
            CarID = request.CarID,
            RaytingValue = request.RaytingValue,
            ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
            Comment = request.Comment
        });
    }
}
