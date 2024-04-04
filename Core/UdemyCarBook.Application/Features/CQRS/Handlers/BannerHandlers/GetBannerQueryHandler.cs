using UdemyCarBook.Application.Features.CQRS.Results.BannerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public class GetBannerQueryHandler(IRepository<Banner> repository)
{
    public async Task<List<GetBannerQueryResult>> Handle()
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetBannerQueryResult
        {
            BannerID = x.BannerID,
            Description = x.Description,
            Title = x.Title,
            VideoDescription = x.VideoDescription,
            VideoUrl = x.VideoUrl
        }).ToList();
    }
}
