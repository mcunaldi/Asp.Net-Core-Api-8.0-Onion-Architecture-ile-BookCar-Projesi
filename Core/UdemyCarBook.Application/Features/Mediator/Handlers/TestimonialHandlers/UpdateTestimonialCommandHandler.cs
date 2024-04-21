using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class UpdateTestimonialCommandHandler(IRepository<Testimonial> repository) : IRequestHandler<UpdateTestimonialCommand>
{
    public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.TestimonialID);
        value.Name = request.Name;
        value.Title = request.Title;
        value.Comment = request.Comment;
        value.ImageUrl = request.ImageUrl;        
        await repository.UpdateAsync(value);
    }
}
