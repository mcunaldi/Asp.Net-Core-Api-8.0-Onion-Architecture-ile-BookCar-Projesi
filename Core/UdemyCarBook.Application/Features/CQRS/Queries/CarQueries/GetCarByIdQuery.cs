namespace UdemyCarBook.Application.Features.CQRS.Queries.CarQueries;
public class GetCarByIdQuery
{
    public int Id { get; set; }

    public GetCarByIdQuery(int id)
    {
        Id = id;
    }
}
