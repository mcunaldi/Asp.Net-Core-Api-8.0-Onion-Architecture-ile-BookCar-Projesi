using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public class GetAboutByIdQueryHandler
{
    private readonly IRepository<About> _repository;

    public GetAboutByIdQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetAboutByIdQueryResult
        {
            AboutID = value.AboutID,
            Description = value.Description,
            ImageUrl = value.ImageUrl,
            Title = value.Title
        };
    }
}
