using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
internal class GetBrandCountQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetBrandCountQuery, GetBrandCountQueryResult>
{
    public async Task<GetBrandCountQueryResult> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetBrandCount();
        return new GetBrandCountQueryResult
        {
            BrandCount = value
        };
    }
}
