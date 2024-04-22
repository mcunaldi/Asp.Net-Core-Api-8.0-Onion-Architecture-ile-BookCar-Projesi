using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;
public class GetCarCountByTransmissionIsAutoQueryHandler(IStatisticsRepository repository) : IRequestHandler<GetCarCountByTransmissionIsAutoQuery, GetCarCountByTransmissionIsAutoQueryResult>
{
    public async Task<GetCarCountByTransmissionIsAutoQueryResult> Handle(GetCarCountByTransmissionIsAutoQuery request, CancellationToken cancellationToken)
    {
        var value = repository.GetCarCountByTransmissionIsAuto();
        return new GetCarCountByTransmissionIsAutoQueryResult
        {
            CarCountByTransmissionIsAuto = value
        };
    }
}
