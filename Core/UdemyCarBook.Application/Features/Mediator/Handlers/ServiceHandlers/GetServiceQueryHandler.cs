using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using UdemyCarBook.Application.Features.Mediator.Results.ServiceResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ServiceHandlers;
public class GetServiceQueryHandler(IRepository<Service> repository) : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
{
    public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetServiceQueryResult()
        {
            ServiceID = x.ServiceID,
            Description = x.Description,
            IconUrl = x.IconUrl,
            Title = x.Title
        }).ToList();
    }
}
