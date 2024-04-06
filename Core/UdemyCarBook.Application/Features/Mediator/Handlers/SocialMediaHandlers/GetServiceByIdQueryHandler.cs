using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;
public class GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository) : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
{
    public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await repository.GetByIdAsync(request.Id);
        return new GetSocialMediaByIdQueryResult
        {
            Url = value.Url,
            Icon = value.Icon,
            Name = value.Name,
            SocialMediaID = value.SocialMediaID,
        };
    }
}
