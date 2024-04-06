using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.TestimonialResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
{
}
