using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class RemoveTestimonialCommandHandler(IRepository<Testimonial> repository) : IRequestHandler<RemoveTestimonialCommand>
{
    public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        await repository.RemoveAsync(value);
    }
}
