using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TestimonialResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository) : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
{
    public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetTestimonialByIdQueryResult
        {
            TestimonialID = value.TestimonialID,
            Name = value.Name,
            Comment = value.Comment,
            ImageUrl = value.ImageUrl,
            Title = value.Title
        };
    }
}
