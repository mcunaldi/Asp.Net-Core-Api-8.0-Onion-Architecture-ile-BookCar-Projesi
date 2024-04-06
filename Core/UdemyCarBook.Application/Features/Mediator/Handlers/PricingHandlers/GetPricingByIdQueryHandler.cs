using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers;
public class GetPricingByIdQueryHandler(IRepository<Pricing> repository) : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
{
    public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetPricingByIdQueryResult
        {
            PricingID = value.PricingID,
            Name  = value.Name
        };
    }
}
