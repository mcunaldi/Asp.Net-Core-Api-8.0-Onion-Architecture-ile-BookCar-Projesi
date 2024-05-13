using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.CarDescriptionResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionQueryResult>
{
    public int Id { get; set; }

    public GetCarDescriptionByCarIdQuery(int id)
    {
        Id = id;
    }
}
