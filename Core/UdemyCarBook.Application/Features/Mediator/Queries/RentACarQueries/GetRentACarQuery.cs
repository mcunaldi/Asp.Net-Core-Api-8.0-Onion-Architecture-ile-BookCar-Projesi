using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.RentACarResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarQuery : IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationID { get; set; }
        public bool Available { get; set; }
    }
}
