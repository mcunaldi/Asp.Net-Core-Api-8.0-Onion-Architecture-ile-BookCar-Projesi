using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
public class GetCarPricingWithCarQuery : IRequest<List<GetCarPricingWithCarQueryResult>>
{
}
