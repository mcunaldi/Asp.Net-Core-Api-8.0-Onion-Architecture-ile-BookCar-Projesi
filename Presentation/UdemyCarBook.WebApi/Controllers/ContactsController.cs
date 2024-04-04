using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.ContactQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactsController(
    GetContactQueryHandler getContactQueryHandler,
    GetContactByIdQueryHandler getContactByIdQueryHandler,
    CreateContactCommandHandler createContactCommandHandler,
    UpdateContactCommandHandler updateContactCommandHandler,
    RemoveContactCommandHandler removeContactCommandHandler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> ContactList()
    {
        var values = await getContactQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBanneer(int id)
    {
        var value = await getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactCommand command)
    {
        await createContactCommandHandler.Handle(command);
        return Ok("İletişim bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveContact(int id)
    {
        await removeContactCommandHandler.Handle(new RemoveContactCommand(id));
        return Ok("İletişim bilgisi silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
    {
        await updateContactCommandHandler.Handle(command);
        return Ok("İletişim bilgisi güncellendi.");
    }
}