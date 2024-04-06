using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class CreateTestimonialCommandHandler(IRepository<Testimonial> repository) : IRequestHandler<CreateTestimonialCommand>
{
    public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Testimonial()
        {
            Name = request.Name,
            Comment = request.Comment,
            ImageUrl = request.ImageUrl,
            Title = request.Title
        });
    }
}
