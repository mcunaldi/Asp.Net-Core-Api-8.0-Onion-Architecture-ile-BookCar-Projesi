using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using UdemyCarBook.Application.Features.Mediator.Results.TestimonialResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;
public class GetTestimonialQueryHandler(IRepository<Testimonial> repository) : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
{
    public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetTestimonialQueryResult()
        {
            TestimonialID = x.TestimonialID,
            Name = x.Name,
            Title = x.Title,
            ImageUrl = x.ImageUrl,
            Comment = x.Comment
        }).ToList();
    }
}
