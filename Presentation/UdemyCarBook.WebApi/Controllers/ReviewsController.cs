using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.ReviewQueries;

namespace UdemyCarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ReviewsController(IMediator mediator) : ControllerBase
{
	[HttpGet]
	public async Task<IActionResult> ReviewListByCarId(int id)
	{
		var values = await mediator.Send(new GetReviewByCarIdQuery(id));
		return Ok(values);
	}
}
