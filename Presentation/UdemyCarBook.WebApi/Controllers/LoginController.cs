using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.AppUserQueries;
using UdemyCarBook.Application.Tools;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LoginController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Login(GetCheckAppUserQuery query)
    {
        var values = await mediator.Send(query);
        if(values.IsExist)
        {
            return Created("", JwtTokenGenerator.GenerateToken(values));
        }
        else
        {
            return BadRequest("Kullanıcı adı veya şifre yanlış");
        }
    }
}
