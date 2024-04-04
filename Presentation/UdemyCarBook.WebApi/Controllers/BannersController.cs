using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.BannerQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BannersController(
    GetBannerQueryHandler getBannerQueryHandler,
    GetBannerByIdQueryHandler getBannerByIdQueryHandler,
    CreateBannerCommandHandler createBannerCommandHandler,
    UpdateBannerCommandHandler updateBannerCommandHandler,
    RemoveBannerCommandHandler removeBannerCommandHandler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> BannerList()
    {
        var values = await getBannerQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBanneer(int id)
    {
        var value = await getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
        return Ok(value);  
    }

    [HttpPost]
    public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
    {
        await createBannerCommandHandler.Handle(command);
        return Ok("Bilgi eklendi.");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveBanner(int id)
    {
        await removeBannerCommandHandler.Handle(new RemoveBannerCommand(id));
        return Ok("Bilgi silindi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
    {
        await updateBannerCommandHandler.Handle(command);
        return Ok("Bilgi güncellendi.");
    }
}
