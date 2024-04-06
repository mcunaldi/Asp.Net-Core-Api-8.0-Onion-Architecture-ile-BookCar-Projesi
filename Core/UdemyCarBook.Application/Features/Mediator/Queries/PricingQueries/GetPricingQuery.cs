using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;
public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
{
}
