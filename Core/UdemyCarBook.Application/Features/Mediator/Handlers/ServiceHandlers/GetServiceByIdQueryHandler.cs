using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using UdemyCarBook.Application.Features.Mediator.Results.ServiceResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ServiceHandlers;
public class GetServiceByIdQueryHandler(IRepository<Service> repository) : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
{
    public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetServiceByIdQueryResult
        {
            ServiceID = value.ServiceID,
            Description  = value.Description,
            Title = value.Title,
            IconUrl = value.IconUrl
        };
    }
}
