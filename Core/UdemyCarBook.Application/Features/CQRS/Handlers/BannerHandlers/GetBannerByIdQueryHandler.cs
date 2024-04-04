using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;
using UdemyCarBook.Application.Features.CQRS.Queries.BannerQueries;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResults;
using UdemyCarBook.Application.Features.CQRS.Results.BannerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class GetBannerByIdQueryHandler(IRepository<Banner> repository)
{
    public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
    {
        var values = await repository.GetByIdAsync(query.Id);
        return new GetBannerByIdQueryResult
        {
            BannerID = values.BannerID,
            Description = values.Description,
            Title = values.Title,
            VideoDescription = values.VideoDescription,
            VideoUrl = values.VideoUrl
        };
    }
}
