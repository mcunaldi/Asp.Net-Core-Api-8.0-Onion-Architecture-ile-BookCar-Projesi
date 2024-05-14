using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.ReviewResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.ReviewQueries;
public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
{
    public int Id { get; set; }

	public GetReviewByCarIdQuery(int id)
	{
		Id = id;
	}
}
