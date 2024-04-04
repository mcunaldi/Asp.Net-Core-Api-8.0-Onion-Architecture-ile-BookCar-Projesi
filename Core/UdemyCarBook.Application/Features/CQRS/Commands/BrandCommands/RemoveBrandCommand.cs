namespace UdemyCarBook.Application.Features.CQRS.Commands.BrandCommands;
public class RemoveBrandCommand
{
    public int Id { get; set; }

    public RemoveBrandCommand(int id)
    {
        Id = id;
    }
}
