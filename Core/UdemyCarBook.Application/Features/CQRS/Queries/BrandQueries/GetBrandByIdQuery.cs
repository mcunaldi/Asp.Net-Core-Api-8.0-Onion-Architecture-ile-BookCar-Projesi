namespace UdemyCarBook.Application.Features.CQRS.Queries.BrandQueries;
public class GetBrandByIdQuery
{
    public int Id { get; set; }

    public GetBrandByIdQuery(int id)
    {
        Id = id;
    }
}
