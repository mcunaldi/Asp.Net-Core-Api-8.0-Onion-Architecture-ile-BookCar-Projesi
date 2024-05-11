using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.CarPricingInterface;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;
public class GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository carPricingRepository) : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
{
	public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
	{

		var values = carPricingRepository.GetCarPricingWithTimePeriod1();
		return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
		{
			Brand = x.Brand,
			Model = x.Model,
			CoverImageUrl = x.CoverImageUrl,
			DailyAmount = x.Amounts[0],
			WeeklyAmount = x.Amounts[1],
			MonthlyAmount = x.Amounts[2]
		}).ToList();
	}
}
