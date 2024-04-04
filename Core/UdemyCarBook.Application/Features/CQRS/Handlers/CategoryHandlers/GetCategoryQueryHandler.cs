using UdemyCarBook.Application.Features.CQRS.Results.CategoryResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
public class GetCategoryQueryHandler(IRepository<Category> repository)
{
    public async Task<List<GetCategoryQueryResult>> Handle()
    {
        var values = await repository.GetAllAsync();
        return values.Select(x => new GetCategoryQueryResult
        {
            CategoryID = x.CategoryID,
            Name = x.Name
        }).ToList();
    }
}
