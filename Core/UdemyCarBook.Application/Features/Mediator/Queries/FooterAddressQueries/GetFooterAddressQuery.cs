using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
{
}
