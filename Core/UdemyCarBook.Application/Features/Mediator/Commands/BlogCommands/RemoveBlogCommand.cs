using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.BlogCommands;
public class RemoveBlogCommand : IRequest
{
    public int Id { get; set; }

    public RemoveBlogCommand(int id)
    {
        Id = id;
    }
}
