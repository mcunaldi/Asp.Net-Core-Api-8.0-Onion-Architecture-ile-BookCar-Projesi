using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.BrandQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandsController(
    GetBrandQueryHandler getBrandQueryHandler,
    GetBrandByIdQueryHandler getBrandByIdQueryHandler,
    CreateBrandCommandHandler createBrandCommandHandler,
    UpdateBrandCommandHandler updateBrandCommandHandler,
    RemoveBrandCommandHandler removeBrandCommandHandler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> BrandList()
    {
        var values = await getBrandQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBanneer(int id)
    {
        var value = await getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
    {
        await createBrandCommandHandler.Handle(command);
        return Ok("Marka bilgisi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveBrand(int id)
    {
        await removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
        return Ok("Marka bilgisi silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
    {
        await updateBrandCommandHandler.Handle(command);
        return Ok("Marka bilgisi güncellendi.");
    }
}