using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.CategoryQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController(
    GetCategoryQueryHandler getCategoryQueryHandler,
    GetCategoryByIdQueryHandler getCategoryByIdQueryHandler,
    CreateCategoryCommandHandler createCategoryCommandHandler,
    UpdateCategoryCommandHandler updateCategoryCommandHandler,
    RemoveCategoryCommandHandler removeCategoryCommandHandler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> CategoryList()
    {
        var values = await getCategoryQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBanneer(int id)
    {
        var value = await getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
    {
        await createCategoryCommandHandler.Handle(command);
        return Ok("Kategori bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveCategory(int id)
    {
        await removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
        return Ok("Kategori bilgisi silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
    {
        await updateCategoryCommandHandler.Handle(command);
        return Ok("Kategori bilgisi güncellendi.");
    }
}